using RZExercise.Interface;
using RZExercise.Models;

namespace RZExercise.Service
{
    public class ApplyService : IApplyService
    {
        public IUserRepo UserRepo;
        public IJobRepo JobRepo;
        public IApplyRepo ApplyRepo;
        public IInterviewRepo InterviewRepo;

        public ApplyService(IUserRepo userRepo, IJobRepo jobRepo, IApplyRepo applyRepo, IInterviewRepo interviewRepo)
        {
            UserRepo = userRepo;
            JobRepo = jobRepo;
            ApplyRepo = applyRepo;
            InterviewRepo = interviewRepo;
        }

        public void ApplyForJob(Guid JobId, Guid UserId)
        {
            User user = UserRepo.GetById(UserId); 
            Job job = JobRepo.GetById(JobId);

            ApplyRepo.ApplyForJob(user, job);

        }
       

        public void DeleteAppliedJob(Guid AppliedId)
        {
            ApplyRepo.DeleteAppliedJob(AppliedId);
        }
        public List<Apply> GetAll()
        {
            return ApplyRepo.GetAll();
        }
        public Apply GetById(Guid id)
        {
            return ApplyRepo.GetById(id);   
        }
    }
}
