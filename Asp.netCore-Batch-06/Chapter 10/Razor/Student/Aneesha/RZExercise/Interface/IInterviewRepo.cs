using RZExercise.Models;

namespace RZExercise.Interface
{
    public interface IInterviewRepo
    {
        void AddInterview(Apply apply);
        void DeleteInterview(Guid id);
        List<Interview> GetAll();
        Interview GetById(Guid id);
    }
}
