using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.UI.MVC.Models
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string PhoneNum { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
    }
}
