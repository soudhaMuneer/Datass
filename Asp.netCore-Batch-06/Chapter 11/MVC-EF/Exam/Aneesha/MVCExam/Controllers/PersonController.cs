using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVCExam.Dto;
using MVCExam.Interface;
using MVCExam.Models;
using MVCExam.Service;
using System;

namespace MVCExam.Controllers
{
    public class PersonController : Controller
    {
        IMapper _mapper;
        IPersonRepo _personRepo;
        IPersonService _PersonService;
        public PersonController(IMapper mapper,IPersonRepo personRepo ,IPersonService personService)
        {
            _mapper = mapper;
            _personRepo = personRepo;
            _PersonService = personService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(PersonDto personDto)
        {

            var person = _mapper.Map<Person>(personDto);
            _PersonService.AddUser(person);
            return RedirectToAction("Login");
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (_PersonService.login(email, password))
            {
                return RedirectToAction("ProfileOfUser");
            }
            else
            {
                return View("LoginError");
            }
        }


        public IActionResult ProfileOfUser()
        {
            var users = _PersonService.GetUsers();
            return View(users);
        }


        public IActionResult Delete(int id)
        {
            _PersonService.DeleteUser(id);
            return View();

        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = _PersonService.GetUser(id);
            if (person == null)
            {
                return NotFound();
            }
            var personDto = _mapper.Map<PersonDto>(person);
            return View(personDto);
        }

        [HttpPost]
        public IActionResult Edit(int id, PersonDto personDto)
        {
            if (id != personDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var person = _mapper.Map<Person>(personDto);
                _PersonService.UpdateUser(person);
                return RedirectToAction("ProfileOfUser", "Person");
            }

            return View(personDto);
        }



    }
}
