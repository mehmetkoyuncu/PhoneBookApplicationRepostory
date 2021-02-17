using PhoneBookApp.ReportService.DataAccess.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.Business_.DTOS
{
    public class ReportItemDTO
    {
        public Guid Id { get; set; }
        public int PersonCount { get; set; }
        public string Location { get; set; }
        public int PhoneCount { get; set; }
        public Status Status { get; set; }
        public DateTime DemandTime { get; set; }
    }
}
