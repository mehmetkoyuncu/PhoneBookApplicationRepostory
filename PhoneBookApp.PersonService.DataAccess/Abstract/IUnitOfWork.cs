using PhoneBookApp.PersonService.DataAccess.Database.Context.EntityFramework;
using PhoneBookApp.PersonService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<Person, PhoneBookAppContextEF> PersonRepository { get; }
        IRepository<Contact, PhoneBookAppContextEF> ContactRepository { get; }
        void Save();
    }
}
