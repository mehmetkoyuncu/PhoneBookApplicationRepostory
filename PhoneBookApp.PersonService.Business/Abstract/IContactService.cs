using PhoneBookApp.PersonService.Business.DTOS;
using PhoneBookApp.PersonService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.Business.Abstract
{
    public interface IContactService
    {
        List<ContactDTO> GetListContact(Guid id);
        bool AddContact(ContactDTO contactDTO);
        bool RemoveContact(int id);
        ContactDTO  GetContact(int id);
        List<ContactDTO> GetAll();
        Contact GetContactJust(int id);
        ReportDTO GetContactReport(string location);
    }
}
