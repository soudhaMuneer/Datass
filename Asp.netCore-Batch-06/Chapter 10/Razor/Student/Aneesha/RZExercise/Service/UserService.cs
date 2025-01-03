using RZExercise.Interface;
using RZExercise.Models;

namespace RZExercise.Service
{
    public class UserService : IUserService
    {
        public IUserRepo UserRepo;
        public IJobRepo JobRepo;
        public IApplyRepo ApplyRepo;
        public IInterviewRepo InterviewRepo;

        public UserService(IUserRepo userRepo, IJobRepo jobRepo, IApplyRepo applyRepo, IInterviewRepo interviewRepo)
        {
            UserRepo = userRepo;
            JobRepo = jobRepo;
            ApplyRepo = applyRepo;
            InterviewRepo = interviewRepo;
        }
        public void AddUser(User user)
        {
            UserRepo.AddUser(user);
        }
        public void UpdateUser(Guid id)
        {
            UserRepo.UpdateUser(id);
        }
        public void DeleteUser(Guid id)
        {
            UserRepo.DeleteUser(id);
        }
        public User GetById(Guid id)
        {
            return UserRepo.GetById(id);
        }
        public List<User> GetAll()
        {
            return UserRepo.GetAll();
        }

        public User Login(string UserName, string password)
        {
            return UserRepo.Login(UserName, password);
        }
        public User register(User user)
        {
            return UserRepo.register(user);
        }
    }
}
