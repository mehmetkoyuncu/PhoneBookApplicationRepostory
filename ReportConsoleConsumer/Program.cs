using MassTransit;
using PhoneBookApp.EventBusConfigurator;
using PhoneBookApp.ReportService.WebAPI.Events;
using System;
using System.Threading.Tasks;

namespace ReportConsoleConsumer
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var bus = BusConfigurator.ConfigureBus(factory =>
            {
                factory.ReceiveEndpoint(RabbitMQConstants.ConsumerQueue, endpoint =>
                {
                    endpoint.Consumer<LocationReportConsumer>();
                });
            });

            await bus.StartAsync();
            await Task.Run(() => Console.ReadLine());
            await bus.StopAsync();
        }
    }
}
