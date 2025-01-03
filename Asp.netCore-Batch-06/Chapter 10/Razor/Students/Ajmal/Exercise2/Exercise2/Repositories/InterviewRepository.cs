using Exercise2.Interface;
using Exercise2.Models;

namespace Exercise2.Repositories
{
    public class InterviewRepository:IInterviewRepository
    {
        private readonly HireMeNowDbContext _context;
        public InterviewRepository(HireMeNowDbContext context)
        {
            _context = context;
        }
     
        public bool ScheduleInterview(Interview interview)
        {
            _context.Interviews.Add(interview);
            _context.SaveChanges();
            return true;
        }
        public List<Interview> GetInterviews()
        {
          return _context.Interviews.ToList();
        }
    }
}
