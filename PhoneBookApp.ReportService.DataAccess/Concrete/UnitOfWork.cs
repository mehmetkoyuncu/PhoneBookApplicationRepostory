using PhoneBookApp.ReportService.DataAccess.Abstract;
using PhoneBookApp.ReportService.DataAccess.Context.EntityFramework;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Concrete
{
    public class UnitOfWork:IUnitOfWork
    {
        PhoneBookAppReportContextEF _context;
        public UnitOfWork()
        {
            _context = new PhoneBookAppReportContextEF();
            ReportRepository = new Repository<ReportItem, PhoneBookAppReportContextEF>(_context);
        }
        public IRepository<ReportItem, PhoneBookAppReportContextEF> ReportRepository { get; }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
