using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.EventBusConfigurator;
using PhoneBookApp.EventBusConfigurator.Abstract;
using PhoneBookApp.EventBusConfigurator.Concrete;
using PhoneBookApp.ReportService.Business_.Abstract;
using PhoneBookApp.ReportService.Business_.DTOS;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.ReportService.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LocationReportController : Controller
    {
        ILocationReportService _locationService;
        public LocationReportController(ILocationReportService locationService)
        {
            _locationService = locationService;
            
        }
        [HttpPost]
        public async Task<IActionResult> DemandLocationReport(LocationReportItemDTO locationReport)
        {

            locationReport.Location = locationReport.Location;

            LocationReport item = _locationService.AddLocationReport(locationReport);
            var reportItem = new LocationReportItem();
            reportItem.Id = item.Id;
            var bus = BusConfigurator.ConfigureBus();
            Uri sendToUri = new Uri($"{RabbitMQConstants.RabbitMqUri}/{RabbitMQConstants.ConsumerQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<ILocationReportItem>(reportItem);
            return Ok("Your report request has been received ");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<LocationReportItemDTO> lst=_locationService.GetAll();
            return Ok(lst);
        }
        [HttpDelete]
        public IActionResult RemoveReport(LocationReportItemDTO reportItem)
        {
            Guid uuid = reportItem.Id;
            bool condition= _locationService.RemoveLocationReport(uuid);
            return Ok(condition);
        }

    }
}
