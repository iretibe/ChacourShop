using ChacourShop.EmailAPI.DbContexts;
using ChacourShop.EmailAPI.Messaging;
using ChacourShop.EmailAPI.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ChacourShop.EmailAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IEmailRepository, EmailRepository>();

            //services.AddHostedService<RabbitMQPaymentConsumer>();

            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            services.AddSingleton(new EmailRepository(optionBuilder.Options));
            services.AddSingleton<IAzureServiceBusConsumer, AzureServiceBusConsumer>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ChacourShop.EmailAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChacourShop.EmailAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseAzureServiceBusConsumer();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
