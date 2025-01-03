using RZExercise.Models;

namespace RZExercise.Interface
{
    public interface IJobService
    {
        List<Job> GetAll();
        Job GetById(Guid id);
    }
}