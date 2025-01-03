using RZExercise.Interface;
using RZExercise.Models;

namespace RZExercise.Service
{
    public class InterviewService : IInterviewService
    {
        public IUserRepo UserRepo;
        public IJobRepo JobRepo;
        public IApplyRepo ApplyRepo;
        public IInterviewRepo InterviewRepo;

        public InterviewService(IUserRepo userRepo, IJobRepo jobRepo, IApplyRepo applyRepo, IInterviewRepo interviewRepo)
        {
            UserRepo = userRepo;
            JobRepo = jobRepo;
            ApplyRepo = applyRepo;
            InterviewRepo = interviewRepo;
        }
        public void AddInterview(Apply apply)
        {
            InterviewRepo.AddInterview(apply);
        }
        public void DeleteInterview(Guid id)
        {
            InterviewRepo.DeleteInterview(id);
        }
        public List<Interview> GetAll()
        {
            return InterviewRepo.GetAll();
        }
        public Interview GetById(Guid id)
        {
            return InterviewRepo.GetById(id);
        }
    }
}
