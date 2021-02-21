using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.Business.DTOS
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string PhoneNum { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string PersonName { get; set; }

    }
}
