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
    public class ContactService : IContactService
    {
        IUnitOfWork _unitOfWork = new UnitOfWork();
        public bool AddContact(ContactDTO contactDTO)
        {
            Contact contact = new Contact
            {
                Address = contactDTO.Address,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
                PersonId = contactDTO.UserId,
                Mail = contactDTO.Mail,
                PhoneNum = contactDTO.PhoneNum
            };
            _unitOfWork.Save();
            return _unitOfWork.ContactRepository.Add(contact);
            
        }

        public ContactDTO GetContact(int id)
        {
            ContactDTO contacDTO = _unitOfWork.ContactRepository.Get(x => x.Id == id&&x.IsDeleted==false).Select(x => new ContactDTO
            {
                Id = x.Id,
                Address = x.Address,
                Mail = x.Mail,
                PhoneNum = x.PhoneNum,
                UserId = x.PersonId
            }).FirstOrDefault();
            return contacDTO;
        }

        public List<ContactDTO> GetListContact(Guid id)
        {
            List<ContactDTO> contactList = _unitOfWork.ContactRepository.Get(x=>x.PersonId==id&&x.IsDeleted==false).Select(x => new ContactDTO
            {
                Address = x.Address,
                Id = x.Id,
                Mail = x.Mail,
                PhoneNum = x.PhoneNum,
                UserId = x.PersonId,
                PersonName=x.Person.Name
            }).ToList();
            return contactList;
        }
        public Contact GetContactJust(int id)
        {
            Contact contact = _unitOfWork.ContactRepository.Get(x => x.Id == id).FirstOrDefault();
            return contact;
        }

        public bool RemoveContact(int id)
        {
            Contact contact = GetContactJust(id);
            contact.IsDeleted = true;
            bool condition = _unitOfWork.ContactRepository.Remove(contact);
            _unitOfWork.Save();
            return condition;
        }

        public List<ContactDTO> GetAll()
        {
            List<ContactDTO> contactDTOList = _unitOfWork.ContactRepository.GetAll().Select(x=>new ContactDTO { 
            Address=x.Address,
            Id=x.Id,
            Mail=x.Mail,
            PhoneNum=x.PhoneNum,
            UserId=x.PersonId
            }).ToList();
            return contactDTOList;
        }
    }
}
