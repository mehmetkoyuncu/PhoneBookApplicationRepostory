using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.PersonService.Business.Abstract;
using PhoneBookApp.PersonService.Business.Concrete;
using PhoneBookApp.PersonService.Business.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.PersonService.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PersonController : Controller
    {
        IPersonServices _personService;
        public PersonController(IPersonServices personservice)
        {
            _personService = personservice;
        }
    
        [HttpGet]
        public IActionResult GetAllPerson()
        {

            return Ok(_personService.GetListPersonDTO());
        }
        public IActionResult GetPerson()
        {
            return Json(_personService.GetPersonDTO(Guid.Parse("{480ab9a9-dafd-4c37-99cf-6c34f74af816}")));
        }
        public IActionResult AddPerson(PersonDTO personDTO)
        {
            bool control = _personService.AddPerson(personDTO);


            return Ok(control);
        }
        [HttpPost]
        public IActionResult RemovePerson(PersonDTO person)
        {
            Guid uuid = person.Id;
            return Ok(_personService.RemovePerson(uuid));
        }

    }
}
