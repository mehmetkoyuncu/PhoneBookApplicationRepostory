using PhoneBookApp.ReportService.DataAccess.Context.EntityFramework;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<LocationReport, PhoneBookAppReportContextEF> ReportRepository { get; }
        void Save();
    }
}
