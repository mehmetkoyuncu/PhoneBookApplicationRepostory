using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.Business_.DTOS
{
    public class LocationReportViewDTO
    {
        public int PersonCount { get; set; }
        public int NumberCount { get; set; }
        public string LocationName { get; set; }
    }
}
