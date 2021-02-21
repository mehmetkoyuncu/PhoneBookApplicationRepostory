using PhoneBookApp.ReportService.DataAccess.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.EventBusConfigurator.Abstract
{
    public interface ILocationReportItem
    {
        public Guid Id { get; set; }
    }
}
