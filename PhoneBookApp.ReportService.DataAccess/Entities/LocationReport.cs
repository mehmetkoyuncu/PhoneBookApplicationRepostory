using PhoneBookApp.ReportService.DataAccess.Consts;
using PhoneBookApp.ReportService.DataAccess.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Entities
{
    public class LocationReport: ReportBase, IEntity
    {
        public Guid Id { get; set; }
        public int PersonCount { get; set; }
        public string Location { get; set; }
        public int PhoneCount { get; set; }
        public StatusEnum Status { get; set; }
    }
}
