using Microsoft.EntityFrameworkCore;
using Workshop.Enums;
using Workshop.Interfaces;
using Workshop.Models;
using Workshop.Repository;

namespace Workshop.Services
{
    public class UserService:IUserService
    {
        private readonly IRegisterUser register;
        public InterviewRepository InterviewRepository= new InterviewRepository();
        public UserService(IRegisterUser _register)
        {
            register = _register ?? throw new ArgumentNullException(nameof(register));
            
        }
        public User Adduser(User user)
        {
            return register.Adduser(user);
        }
        public User Login(string Email, string password)
        {
           
            return register.Login(Email, password);
        }
        public List<User> Getuser()
        {
            return register.Getuser();
        }

        public bool ScheduleInterview(Interviews interviews)
        {
            InterviewRepository.ScheduleInterview(interviews);
            return true;
        }
         public  List<Interviews> GetInterviews()
        {
          return InterviewRepository.GetInterviews();

        }
    }
}
