using PhoneBookApp.PersonService.DataAccess.Abstract;
using PhoneBookApp.PersonService.DataAccess.Database.Context.EntityFramework;
using PhoneBookApp.PersonService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.DataAccess.Concrete
{
   public  class UnitOfWork:IUnitOfWork
    {
        PhoneBookAppContextEF _context;
        public UnitOfWork()
        {
            _context = new PhoneBookAppContextEF();
            PersonRepository = new Repository<Person, PhoneBookAppContextEF>(_context);
            ContactRepository = new Repository<Contact, PhoneBookAppContextEF>(_context);
        }
        public IRepository<Person, PhoneBookAppContextEF> PersonRepository { get; }
        public IRepository<Contact, PhoneBookAppContextEF> ContactRepository { get; }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
