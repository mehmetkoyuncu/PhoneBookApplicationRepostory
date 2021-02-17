using Microsoft.EntityFrameworkCore;
using PhoneBookApp.ReportService.DataAccess.Context.DummyData;
using PhoneBookApp.ReportService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Context.EntityFramework
{
    public class PhoneBookAppReportContextEF:DbContext
    {
        public DbSet<ReportItem> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=PhoneBookAppReportDB;Integrated Security=true; User Id=postgres;Password=7973153.mK;");
        }
        Datas dummyData = new Datas();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportItem>().HasData(
                dummyData.reportItems
                );
        }
    }
}
