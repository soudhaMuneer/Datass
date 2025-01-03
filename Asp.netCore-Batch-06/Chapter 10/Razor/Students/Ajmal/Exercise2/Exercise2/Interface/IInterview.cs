using Exercise2.Models;

namespace Exercise2.Interface
{
    public interface IInterview
    {
        bool ScheduleInterview(Interview interview);
        List<Interview> GetInterviews();
    }
}
