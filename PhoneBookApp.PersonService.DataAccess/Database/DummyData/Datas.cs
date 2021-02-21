using PhoneBookApp.PersonService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.DataAccess.Database.DummyData
{
   public class Datas
    {
        public List<Person> Persons { get; set; }
        public Datas()
        {
            Persons = new List<Person>()
                {
                    new Person
                    {
                        CompanyName="Bilge Adam",
                        CreatedTime=DateTime.Now,
                        Id=Guid.NewGuid(),
                        IsDeleted=false,
                        Name="Mehmet",
                        Surname="Koyuncu"
                    },
                    new Person
                    {
                        CompanyName="Setur",
                        CreatedTime=DateTime.Now,
                        Id=Guid.NewGuid(),
                        IsDeleted=true,
                        Name="Name 1",
                        Surname="Name 2"
                    }
                };
        }
    }
}
