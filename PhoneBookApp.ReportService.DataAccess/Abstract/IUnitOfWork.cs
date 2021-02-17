using PhoneBookApp.ReportService.DataAccess.Context.EntityFramework;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<ReportItem, PhoneBookAppReportContextEF> PersonRepository { get; }
        void Save();
    }
}
