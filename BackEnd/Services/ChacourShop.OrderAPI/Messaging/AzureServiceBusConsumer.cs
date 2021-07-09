using Azure.Messaging.ServiceBus;
using ChacourShop.MessageBus;
using ChacourShop.OrderAPI.Messages;
using ChacourShop.OrderAPI.Models;
using ChacourShop.OrderAPI.Repository;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChacourShop.OrderAPI.Messaging
{
    public class AzureServiceBusConsumer : IAzureServiceBusConsumer
    {
        private readonly string serviceBusConnectionString;
        private readonly string subscriptionCheckOut;
        private readonly string checkoutMessageTopic;
        private readonly string orderPaymentProcessTopic;
        private readonly string orderUpdatePaymentResultTopic;

        private readonly OrderRepository _orderRepository;

        private ServiceBusProcessor checkOutProcessor;
        private ServiceBusProcessor orderUpdatePaymentStatusProcessor;

        private readonly IConfiguration _configuration;
        private readonly IMessageBus _messageBus;

        public AzureServiceBusConsumer(OrderRepository orderRepository, IConfiguration configuration, IMessageBus messageBus)
        {
            _orderRepository = orderRepository;
            _configuration = configuration;
            _messageBus = messageBus;

            serviceBusConnectionString = _configuration.GetValue<string>("ServiceBusConnectionString");
            subscriptionCheckOut = _configuration.GetValue<string>("SubscriptionCheckOut");
            checkoutMessageTopic = _configuration.GetValue<string>("CheckoutMessageTopic");
            orderPaymentProcessTopic = _configuration.GetValue<string>("OrderPaymentProcessTopics");
            orderUpdatePaymentResultTopic = _configuration.GetValue<string>("OrderUpdatePaymentResultTopic");

            var client = new ServiceBusClient(serviceBusConnectionString);

            checkOutProcessor = client.CreateProcessor(checkoutMessageTopic);
            orderUpdatePaymentStatusProcessor = client.CreateProcessor(orderUpdatePaymentResultTopic, subscriptionCheckOut);
        }

        public async Task Start()
        {
            checkOutProcessor.ProcessMessageAsync += OnCheckOutMessageReceived;
            checkOutProcessor.ProcessErrorAsync += ErrorHandler;
            await checkOutProcessor.StartProcessingAsync();

            orderUpdatePaymentStatusProcessor.ProcessMessageAsync += OnOrderPaymentUpdateReceived;
            orderUpdatePaymentStatusProcessor.ProcessErrorAsync += ErrorHandler;
            await orderUpdatePaymentStatusProcessor.StartProcessingAsync();
        }

        public async Task Stop()
        {
            await checkOutProcessor.StopProcessingAsync();
            await checkOutProcessor.DisposeAsync();

            await orderUpdatePaymentStatusProcessor.StopProcessingAsync();
            await orderUpdatePaymentStatusProcessor.DisposeAsync();
        }

        Task ErrorHandler(ProcessErrorEventArgs args)
        {
            Console.WriteLine(args.Exception.ToString());
            return Task.CompletedTask;
        }

        private async Task OnCheckOutMessageReceived(ProcessMessageEventArgs args)
        {
            var message = args.Message;
            var body = Encoding.UTF8.GetString(message.Body);

            CheckoutHeaderDto checkoutHeaderDto = JsonConvert.DeserializeObject<CheckoutHeaderDto>(body);

            OrderHeader orderHeader = new()
            {
                UserId = checkoutHeaderDto.UserId,
                FirstName = checkoutHeaderDto.FirstName,
                LastName = checkoutHeaderDto.LastName,
                OrderDetails = new List<OrderDetails>(),
                CardNumber = checkoutHeaderDto.CardNumber,
                CouponCode = checkoutHeaderDto.CouponCode,
                CVV = checkoutHeaderDto.CVV,
                DiscountTotal = checkoutHeaderDto.DiscountTotal,
                Email = checkoutHeaderDto.Email,
                ExpiryMonthYear = checkoutHeaderDto.ExpiryMonthYear,
                OrderTime = DateTime.Now,
                OrderTotal = checkoutHeaderDto.OrderTotal,
                PaymentStatus = false,
                Phone = checkoutHeaderDto.Phone,
                PickupDateTime = checkoutHeaderDto.PickupDateTime
            };

            foreach (var detailList in checkoutHeaderDto.CartDetails)
            {
                OrderDetails orderDetails = new()
                {
                    ProductId = detailList.ProductId,
                    ProductName = detailList.Product.ProductName,
                    Price = detailList.Product.Price,
                    Count = detailList.Count
                };

                orderHeader.CartTotalItems += detailList.Count;
                orderHeader.OrderDetails.Add(orderDetails);
            }

            await _orderRepository.AddOrder(orderHeader);

            PaymentRequestMessage paymentRequestMessage = new()
            {
                Name = orderHeader.FirstName + " " + orderHeader.LastName,
                CardNumber = orderHeader.CardNumber,
                CVV = orderHeader.CVV,
                ExpiryMonthYear = orderHeader.ExpiryMonthYear,
                OrderId = orderHeader.OrderHeaderId,
                OrderTotal = orderHeader.OrderTotal,
                Email = orderHeader.Email
            };

            try
            {
                await _messageBus.PublishMessage(paymentRequestMessage, orderPaymentProcessTopic);
                await args.CompleteMessageAsync(args.Message);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private async Task OnOrderPaymentUpdateReceived(ProcessMessageEventArgs args)
        {
            var message = args.Message;
            var body = Encoding.UTF8.GetString(message.Body);

            UpdatePaymentResultMessage paymentResultMessage = JsonConvert.DeserializeObject<UpdatePaymentResultMessage>(body);

            await _orderRepository.UpdateOrderPaymentStatus(paymentResultMessage.OrderId, paymentResultMessage.Status);
            await args.CompleteMessageAsync(args.Message);
        }
    }
}
