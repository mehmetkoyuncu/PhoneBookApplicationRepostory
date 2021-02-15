using Microsoft.EntityFrameworkCore;
using PhoneBookApp.PersonService.DataAccess.Database.DummyData;
using PhoneBookApp.PersonService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.DataAccess.Database.Context.EntityFramework
{
    public class PhoneBookAppContextEF:DbContext
    {
        public DbSet<Person> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=PhoneBookAppDBTestDBB;Integrated Security=true; User Id=postgres;Password=7973153.mK;");
        }
        Datas dummyData = new Datas();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                dummyData.Persons
                );
        }
    }
}
