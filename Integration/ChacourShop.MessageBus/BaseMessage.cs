﻿using System;

namespace ChacourShop.MessageBus
{
    public class BaseMessage
    {
        public int Id { get; set; }
        public DateTime MessageCreated { get; set; }
    }
}
