using RZExercise.DAL;
using RZExercise.Interface;
using RZExercise.Models;

namespace RZExercise.Repository
{
    public class ApplyRepository : IApplyRepo
    {
        private SeekerDBContext _dbContext;
        public Apply app = new Apply();
        public List<Apply> appList = new List<Apply>();
        public void ApplyForJob(User user,Job job)
        {
   
            var newApply = new Apply
            {
                UserId = user.UserId,
                JobId = job.JobId
            };

            _dbContext.Applies.Add(newApply);
            _dbContext.SaveChanges();
        }
        public void UpgradeForJob(Guid appliedId, string newStatus)
        {
            var apply = _dbContext.Applies.FirstOrDefault(e => e.ApplyId == appliedId);
            if (apply != null)
            {
                apply.Resume = newStatus;
                apply.CoverLetter = newStatus;
                _dbContext.SaveChanges();
            }

        }
        public void DeleteAppliedJob(Guid AppliedId)
        {
            var remove = _dbContext.Applies.FirstOrDefault(e => e.ApplyId == AppliedId);
            _dbContext.Applies.Remove(remove);
            _dbContext.SaveChanges();
        }
        public List<Apply> GetAll()
        {
           return _dbContext.Applies.ToList();
        }
        public Apply GetById(Guid id)
        {
            return _dbContext.Applies.FirstOrDefault(e=>e.ApplyId == id);   
        }
    }
}
