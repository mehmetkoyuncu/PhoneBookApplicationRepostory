using PhoneBookApp.PersonService.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.DataAccess.Entities
{
    public class Person:BaseEntity,IEntity
    {
        public Person()
        {
            Contacts = new List<Contact>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
    }
}
