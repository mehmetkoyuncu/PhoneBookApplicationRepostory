using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.UI.MVC.Models
{
    public class PersonDTO
    {
        public PersonDTO()
        {
            Contacts = new List<ContactDTO>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public IEnumerable<ContactDTO> Contacts { get; set; }
    }
}
