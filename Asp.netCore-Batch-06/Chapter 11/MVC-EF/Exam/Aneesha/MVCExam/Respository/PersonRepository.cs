using Microsoft.EntityFrameworkCore;
using MVCExam.Dto;
using MVCExam.Enums;
using MVCExam.Interface;
using MVCExam.Models;

namespace MVCExam.Respository
{
    public class PersonRepository : IPersonRepo
    {
     

        PersonDBContext dbContext = new PersonDBContext();
        public PersonRepository(PersonDBContext personDBContext)
        {
            dbContext = personDBContext;
        }


        public Person AddUser(Person person)
        {
            person.Roles = Roles.Admin;
            dbContext.Persons.Add(person);
            dbContext.SaveChanges();
            return person;
        }

        public Person login(string email, string password)
        {
            return dbContext.Persons.Where(e => e.Email == email && e.Password == password).FirstOrDefault();
        
        }

        public List<Person> GetUsers()
        {
            return dbContext.Persons.ToList();
        }
        public Person GetUser(int id)
        {
            var person = dbContext.Persons.Where(x => x.Id == id).FirstOrDefault();
            return person;
        }
       
        public void DeleteUser(int id)
        {
            var remove = dbContext.Persons.Find(id);
            if (remove == null)
            {
                return;
            }
            dbContext.Persons.Remove(remove);
            dbContext.SaveChanges();

        }

        public void UpdateUser(Person person)
        {
            dbContext.Persons.Update(person);
            dbContext.SaveChanges();
        }
    }
}
