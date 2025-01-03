using RZExercise.Models;

namespace RZExercise.Interface
{
    public interface IApplyService
    {
        void ApplyForJob(Guid JobId, Guid UserId);
        void DeleteAppliedJob(Guid AppliedId);
        List<Apply> GetAll();
        Apply GetById(Guid id);
    }
}
