using RZExercise.Models;

namespace RZExercise.Interface
{
    public interface IJobRepo
    {
        List<Job> GetAll();
        Job GetById(Guid id);
    }
}
