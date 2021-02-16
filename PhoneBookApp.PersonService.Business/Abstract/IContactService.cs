using PhoneBookApp.PersonService.Business.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.Business.Abstract
{
    public interface IContactService
    {
        List<ContactDTO> GetListContact(Guid id);
        bool AddContact(ContactDTO contactDTO);
        bool RemoveContact(Guid id);
        ContactDTO  GetContact(int id);
    }
}
