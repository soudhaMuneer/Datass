using RZExercise.Dto;
using RZExercise.Models;

namespace RZExercise.Interface
{
    public interface IUserService
    {
        void AddUser(User user);
        void UpdateUser(Guid id);
        void DeleteUser(Guid id);
        User GetById(Guid id);
        List<User> GetAll();

        User Login(string UserName, string password);
        User register(User user);
        
    }
}
