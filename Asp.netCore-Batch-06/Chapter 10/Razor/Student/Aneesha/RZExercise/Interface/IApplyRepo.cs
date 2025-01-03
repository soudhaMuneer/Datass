using RZExercise.Models;

namespace RZExercise.Interface
{
    public interface IApplyRepo
    {
        void ApplyForJob(User user, Job job);
        void UpgradeForJob(Guid appliedId, string newStatus);
        void DeleteAppliedJob(Guid AppliedId);
        List<Apply> GetAll();
        Apply GetById(Guid id);

    }
}
