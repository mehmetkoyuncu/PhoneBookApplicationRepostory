using MassTransit;
using MassTransit.RabbitMqTransport;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.EventBusConfigurator
{
    public class BusConfigurator
    {
        public static IBusControl ConfigureBus(Action<IRabbitMqBusFactoryConfigurator> registrationAction = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(factory =>
            {
                factory.Host(RabbitMQConstants.RabbitMqUri, configurator =>
                {
                    configurator.Username(RabbitMQConstants.Username);
                    configurator.Password(RabbitMQConstants.Password);
                });

                registrationAction?.Invoke(factory);
            });

        }
    }
}
