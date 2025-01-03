using Azure.Core;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MVCExam.Dto;
using MVCExam.Interface;
using MVCExam.Models;
using System.Net;
using System.Runtime.Intrinsics.X86;

namespace MVCExam.Service
{
    public class PersonService : IPersonService
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public IPersonRepo personRepo;
        PersonDBContext personDBContext;
        bool log = false;
        public static Person loggedUser = new Person();
        public PersonService(IPersonRepo personRepo, PersonDBContext personDBContext, IHttpContextAccessor contextAccessor)
        {
            this.personRepo = personRepo;
            this.personDBContext = personDBContext;
            _contextAccessor = contextAccessor;
        }
        //In ASP.NET Core, the HttpContext is not a static object like it was in the old ASP.NET framework.
        //Instead, it's an instance that's created for each incoming request.This change was made to improve performance and scalability.
        //The IHttpContextAccessor interface is a way to access the current HttpContext instance from within a service class.
        //By injecting IHttpContextAccessor into your service class, you can get the current HttpContext instance and use its properties and methods, such as the Session property.

        // Store the logged in user in a session
        //_contextAccessor.HttpContext.Session.SetString("LoggedInUser",loggedUser.Id.ToString());

        public Person AddUser(Person person)
        {
            personRepo.AddUser(person);
            return person;
        }


        public bool login(string email, string password)
        {
            Person loggedUser = personRepo.login(email, password);


            if (loggedUser == null)
            {
                Console.WriteLine("Login failed");
                return false;
            }

            Console.WriteLine("Login successful");
            log = true;

            
            _contextAccessor.HttpContext.Session.SetString("LoggedInUser",loggedUser.Id.ToString());

            return true;
        }

        
        public List<Person> GetUsers()
        {
            return personRepo.GetUsers();
        }
        public Person GetUser(int id)
        {
            return personRepo.GetUser(id);
        }
        public void DeleteUser(int id)
        {
            personRepo.DeleteUser(id);
        }

        public void UpdateUser(Person person)
        {
            var existingPerson = personDBContext.Persons.Find(person.Id);

            if (existingPerson != null)
            {

                existingPerson.Name = person.Name;
                existingPerson.Email = person.Email;
                existingPerson.Password = person.Password;
                existingPerson.Description = person.Description;
                existingPerson.Address = person.Address;
                existingPerson.City = person.City;


                personDBContext.SaveChanges();
            }
        }
    }
}