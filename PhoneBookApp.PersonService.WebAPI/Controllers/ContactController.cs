using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.PersonService.Business.Abstract;
using PhoneBookApp.PersonService.Business.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.PersonService.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ContactController : Controller
    {
        IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
      
        [HttpPost]
        public IActionResult GetContactForUser(ContactDTO contactDTO)
        {
            Guid id = contactDTO.UserId; 
            return Ok(_contactService.GetListContact(id));
        }
        [HttpGet]
        public void GetAll()
        {
            List<ContactDTO> contactDTOs = _contactService.GetAll();
            
        }
        [HttpPost]
        public IActionResult AddContact(ContactDTO contacts)
        {
            _contactService.AddContact(contacts);

            bool control=_contactService.AddContact(contacts);
            return Ok(control);
        }
        [HttpDelete]
        public IActionResult RemoveContact(ContactDTO contact)
        {
            return Ok(_contactService.RemoveContact(Convert.ToInt32(contact.Id)));
        }
        [HttpPost]
        public IActionResult GetRecordCounts(ContactDTO contactDTO)
        {
            ReportDTO reportDTO = _contactService.GetContactReport(contactDTO.Address);
            return Ok(reportDTO);
        }

    }
}
