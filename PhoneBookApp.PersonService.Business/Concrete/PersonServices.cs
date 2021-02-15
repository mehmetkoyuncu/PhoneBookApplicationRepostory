using PhoneBookApp.PersonService.Business.Abstract;
using PhoneBookApp.PersonService.Business.DTOS;
using PhoneBookApp.PersonService.DataAccess.Abstract;
using PhoneBookApp.PersonService.DataAccess.Concrete;
using PhoneBookApp.PersonService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookApp.PersonService.Business.Concrete
{
    public class PersonServices:IPersonServices
    {
        IUnitOfWork _unitOfWork = new UnitOfWork();

        public bool AddPerson(PersonDTO personDTO)
        {
            Person person = new Person()
            {
                CompanyName = personDTO.CompanyName,
                Id = Guid.NewGuid(),
                IsDeleted = false,
                CreatedTime = DateTime.Now,
                Name = personDTO.Name,
                Surname = personDTO.Surname
            };
            bool condition = _unitOfWork.PersonRepository.Add(person);
            _unitOfWork.Save();
            return condition;
        }

        public List<PersonDTO> GetListPersonDTO()
        {
            List<PersonDTO> personList = _unitOfWork.PersonRepository.Get(x=>x.IsDeleted==false).Select(x => new PersonDTO
            {
                CompanyName = x.CompanyName,
                Name = x.Name,
                Id = x.Id,
                Surname = x.Surname,
                Contacts = x.Contacts.Where(y => y.PersonId == x.Id&&x.IsDeleted==false).Select(y => new ContactDTO
                {
                    Address = y.Address,
                    Id = y.Id,
                    Mail = y.Mail,
                    PhoneNum = y.PhoneNum
                }).ToList()
            }).OrderByDescending(x => x.Name).ToList();
            return personList;
        }

        public PersonDTO GetPersonDTO(Guid id)
        {
            PersonDTO person = _unitOfWork.PersonRepository.Get(x => x.Id == id&&x.IsDeleted==false).Select(x => new PersonDTO
            {
                CompanyName = x.CompanyName,
                Name = x.Name,
                Id = x.Id,
                Surname = x.Surname,
                Contacts = x.Contacts.Where(y => y.PersonId == x.Id).Select(y => new ContactDTO
                {
                    Address = y.Address,
                    Id = y.Id,
                    Mail = y.Mail,
                    PhoneNum = y.PhoneNum
                }).ToList()
            }).FirstOrDefault();
            return person;
        }
        public Person GetPerson(Guid id)
        {
            Person person = _unitOfWork.PersonRepository.Get(x => x.Id == id).FirstOrDefault();
            return person;
        }

        public bool RemovePerson(Guid id)
        {
            Person person = GetPerson(id);
            person.IsDeleted = true;
            bool condition = _unitOfWork.PersonRepository.Remove(person);
            _unitOfWork.Save();
            return condition;
        }
    }
}
