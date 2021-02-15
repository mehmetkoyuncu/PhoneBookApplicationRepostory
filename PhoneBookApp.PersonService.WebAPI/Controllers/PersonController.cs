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
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllPerson()
        {

            return Json(_personService.GetListPersonDTO());
        }
        public IActionResult GetPerson()
        {
            return Json(_personService.GetPersonDTO(Guid.Parse("{480ab9a9-dafd-4c37-99cf-6c34f74af816}")));
        }
        public IActionResult AddPerson()
        {
            PersonDTO personDTO1 = new PersonDTO();
            personDTO1.Id = Guid.NewGuid();
            personDTO1.CompanyName = "Company 1 ";
            personDTO1.Name = "Ex Data";
            personDTO1.Surname = "Ex Data";
            return Json(_personService.AddPerson(personDTO1));
        }
        public IActionResult RemovePerson()
        {
            Guid id = Guid.Parse("{5df9ae2a-e923-47db-a5dd-1e1c8fc2d00b}");
            return Json(_personService.RemovePerson(id));
        }

    }
}
