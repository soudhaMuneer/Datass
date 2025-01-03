using RZExercise.Interface;
using RZExercise.Models;

namespace RZExercise.Service
{
    public class JobService : IJobService
    {
        public IUserRepo UserRepo;
        public IJobRepo JobRepo;
        public IApplyRepo ApplyRepo;
        public IInterviewRepo InterviewRepo;

        public JobService(IUserRepo userRepo, IJobRepo jobRepo, IApplyRepo applyRepo, IInterviewRepo interviewRepo)
        {
            UserRepo = userRepo;
            JobRepo = jobRepo;
            ApplyRepo = applyRepo;
            InterviewRepo = interviewRepo;
        }
        public List<Job> GetAll()
        {
            return JobRepo.GetAll();
        }
        public Job GetById(Guid id)
        {
            return JobRepo.GetById(id);
        }
    }
}
