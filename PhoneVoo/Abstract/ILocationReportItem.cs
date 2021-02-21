using PhoneBookApp.ReportService.DataAccess.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.EventBusConfiguratorCore.Abstract
{
    public interface ILocationReportItem
    {
        public Guid Id { get; set; }
        public int PersonCount { get; set; }
        public string Location { get; set; }
        public int PhoneCount { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime CreaatedTime { get; set; }
        public DateTime DemandTime { get; set; }
    }
}
