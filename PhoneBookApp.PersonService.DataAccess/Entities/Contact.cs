using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.DataAccess.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string PhoneNum { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
