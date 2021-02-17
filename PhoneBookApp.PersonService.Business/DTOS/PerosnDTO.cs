using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.Business.DTOS
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
        public DateTime CreatedTime { get; set; }
    }
}
