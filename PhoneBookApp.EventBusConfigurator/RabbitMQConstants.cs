using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.EventBusConfigurator
{
    public class RabbitMQConstants
    {
        public const string RabbitMqUri = "rabbitmq://localhost/";
        public const string Username = "guest";
        public const string Password = "guest";
        public const string ConsumerQueue = "receiver";

    }
}
