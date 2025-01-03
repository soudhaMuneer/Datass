using Exercise2.Models;

namespace Exercise2.Interface
{
    public interface IInterviewRepository
    {
        bool ScheduleInterview(Interview interview);
        List<Interview> GetInterviews();
    }
}
