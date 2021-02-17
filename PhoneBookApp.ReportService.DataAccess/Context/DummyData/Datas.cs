using PhoneBookApp.ReportService.DataAccess.Consts;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Context.DummyData
{
   public class Datas
    {
        public List<ReportItem> reportItems { get; set; }

        public Datas()
        {
            reportItems = new List<ReportItem>()
            {
                new ReportItem
                {
                    Id=Guid.NewGuid(),
                    Location="Istanbul",
                    PersonCount=5,
                    PhoneCount=10,
                    Status=Status.Done
                },
                 new ReportItem
                {
                    Id=Guid.NewGuid(),
                    Location="Rize",
                    PersonCount=3,
                    PhoneCount=20,
                    Status=Status.Ready
                },
                  new ReportItem
                {
                    Id=Guid.NewGuid(),
                    Location="Antalya",
                    PersonCount=25,
                    PhoneCount=50,
                    Status=Status.Ready
                },
                   new ReportItem
                {
                    Id=Guid.NewGuid(),
                    Location="Eskişehir",
                    PersonCount=35,
                    PhoneCount=150,
                    Status=Status.Done
                },
            };
        }
    }
}
