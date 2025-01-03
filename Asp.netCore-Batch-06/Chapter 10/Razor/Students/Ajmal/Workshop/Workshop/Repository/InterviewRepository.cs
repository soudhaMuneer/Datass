using Workshop.Interfaces;
using Workshop.Models;

namespace Workshop.Repository
{
    public class InterviewRepository:IInterview
    {
        public HireMeNowDbContext Context = new HireMeNowDbContext();
        public InterviewRepository()
        {
                
        }
        public bool ScheduleInterview(Interviews interviews)
        {
         Context.Interviews.Add(interviews);
            Context.SaveChanges();
            return true;
        }
        public List<Interviews> GetInterviews()
        {
            
            return Context.Interviews.ToList();
        }
    }
}
