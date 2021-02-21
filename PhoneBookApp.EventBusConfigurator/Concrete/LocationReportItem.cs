using PhoneBookApp.EventBusConfigurator.Abstract;
using PhoneBookApp.ReportService.DataAccess.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.EventBusConfigurator.Concrete
{
   public class LocationReportItem:ILocationReportItem
    {
        public Guid Id { get; set; }
    }
}
