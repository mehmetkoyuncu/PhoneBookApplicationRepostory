using MassTransit;
using Newtonsoft.Json;
using PhoneBookApp.EventBusConfigurator;
using PhoneBookApp.EventBusConfigurator.Abstract;
using PhoneBookApp.EventBusConfigurator.Concrete;
using PhoneBookApp.ReportService.Business_.DTOS;
using PhoneBookApp.ReportService.DataAccess.Consts;
using PhoneBookApp.ReportService.DataAccess.Context.EntityFramework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.ReportService.WebAPI.Events
{
    public class LocationReportConsumer: IConsumer<ILocationReportItem>
    {
        public LocationReportConsumer()
        {
            var bus = BusConfigurator.ConfigureBus(factory =>
            {
                factory.ReceiveEndpoint(RabbitMQConstants.ConsumerQueue, endpoint =>
                {
                    endpoint.Consumer<LocationReportConsumer>();
                });
            });

            bus.StartAsync();
        }
        public async Task Consume(ConsumeContext<ILocationReportItem> context)
        {

            Console.WriteLine($"The report has been saved in the database.");

            using (PhoneBookAppReportContextEF reportContext = new PhoneBookAppReportContextEF())
            {
                var report = reportContext.Reports.FirstOrDefault(x => x.Id == context.Message.Id);

                if (report != null)
                {
                    var client = new RestClient("https://localhost:44347/Contact/GetRecordCounts");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/json");
                    LocationAddressDTO data = new LocationAddressDTO();
                    data.Address = report.Location;
                    request.AddParameter("application/json", JsonConvert.SerializeObject(data), ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    var responsedata = JsonConvert.DeserializeObject<LocationReportViewDTO>(response.Content);
                    report.PhoneCount = responsedata.NumberCount;
                    report.PersonCount = responsedata.PersonCount;
                    report.Status = StatusEnum.Done;
                    reportContext.Reports.Update(report);
                    await reportContext.SaveChangesAsync();
                }
            }
        }
    }
}
