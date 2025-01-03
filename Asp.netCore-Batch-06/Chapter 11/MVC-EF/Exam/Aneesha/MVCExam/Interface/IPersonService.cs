using MVCExam.Dto;
using MVCExam.Models;

namespace MVCExam.Interface
{
    public interface IPersonService
    {
        Person AddUser(Person person);
        bool login(string email, string password);
        List<Person> GetUsers();
        Person GetUser(int id);
        void DeleteUser(int id);

        void UpdateUser(Person person);
    }
}
