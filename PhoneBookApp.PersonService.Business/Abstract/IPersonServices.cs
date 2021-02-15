using PhoneBookApp.PersonService.Business.DTOS;
using PhoneBookApp.PersonService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.PersonService.Business.Abstract
{
    public interface IPersonServices
    {
        List<PersonDTO> GetListPersonDTO();
        bool AddPerson(PersonDTO person);
        bool RemovePerson(Guid id);
        PersonDTO GetPersonDTO(Guid id);
        Person GetPerson(Guid id);
    }
}
