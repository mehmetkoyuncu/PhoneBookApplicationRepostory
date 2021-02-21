using PhoneBookApp.ReportService.DataAccess.Consts;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Context.DummyData
{
   public class Datas
    {
        public List<LocationReport> reportItems { get; set; }

        public Datas()
        {
            reportItems = new List<LocationReport>()
            {
                new LocationReport
                {
                    Id=Guid.NewGuid(),
                    Location="Istanbul",
                    PersonCount=5,
                    PhoneCount=10,
                    Status=StatusEnum.Done,
                    CreaatedTime=DateTime.Now,
                    DemandTime=DateTime.Now,
                    IsDeleted=false
                    
                },
                 new LocationReport
                {
                    Id=Guid.NewGuid(),
                    Location="Rize",
                    PersonCount=3,
                    PhoneCount=20,
                    Status=StatusEnum.Ready,
                    CreaatedTime=DateTime.Now,
                    DemandTime=DateTime.Now,
                    IsDeleted=true
                },
                  new LocationReport
                {
                    Id=Guid.NewGuid(),
                    Location="Antalya",
                    PersonCount=25,
                    PhoneCount=50,
                    Status=StatusEnum.Ready,
                    CreaatedTime=DateTime.Now,
                    DemandTime=DateTime.Now,
                    IsDeleted=true
                },
                   new LocationReport
                {
                    Id=Guid.NewGuid(),
                    Location="Eskişehir",
                    PersonCount=35,
                    PhoneCount=150,
                    Status=StatusEnum.Done,
                    CreaatedTime=DateTime.Now,
                    DemandTime=DateTime.Now,
                    IsDeleted=false
                },
            };
        }
    }
}
