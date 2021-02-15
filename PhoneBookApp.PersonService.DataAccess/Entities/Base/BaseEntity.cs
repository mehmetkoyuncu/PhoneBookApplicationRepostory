using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.DataAccess.Entities.Base
{
    public abstract class BaseEntity
    {
        public DateTime CreatedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
