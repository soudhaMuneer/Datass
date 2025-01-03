using Workshop.Models;

namespace Workshop.Interfaces
{
    public interface IInterview
    {
        bool ScheduleInterview(Interviews interviews);
        List<Interviews> GetInterviews();
    }
}
