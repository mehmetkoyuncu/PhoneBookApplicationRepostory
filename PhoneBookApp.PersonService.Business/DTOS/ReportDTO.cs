using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.Business.DTOS
{
   public class ReportDTO
    {
        public int NumberCount { get; set; }
        public int PersonCount { get; set; }
        public string Name { get; set; }
    }
}
