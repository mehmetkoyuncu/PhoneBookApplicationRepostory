using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Entities.BaseEntities
{
   public abstract class ReportBase
    {
        public DateTime CreaatedTime { get; set; }
        public DateTime DemandTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
