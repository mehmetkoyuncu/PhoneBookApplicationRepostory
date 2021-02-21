using MassTransit;
using PhoneBookApp.ReportService.WebAPI.Events;
using PhoneDirectoryApp.MessageContracts;
using System;
using System.Threading.Tasks;

namespace PhoneDirectoryApp.Registration
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var bus = BusConfigurator.ConfigureBus(factory =>
            {
                factory.ReceiveEndpoint(RabbitMqConstants.RegistrationServiceQueue, endpoint =>
                {
                    endpoint.Consumer<ReportRegistrationCommandConsumer>();
                });
            });

            await bus.StartAsync();
            await Task.Run(() => Console.ReadLine());
            await bus.StopAsync();
        }
    }
}
