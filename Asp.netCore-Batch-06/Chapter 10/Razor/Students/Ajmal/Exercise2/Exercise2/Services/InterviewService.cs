using Exercise2.Interface;
using Exercise2.Models;
using Exercise2.Repositories;

namespace Exercise2.Services
{
    public class InterviewService:IInterview
    {
        
        private readonly IInterviewRepository interviewRepository;
      
        public InterviewService(IInterviewRepository _interviewRepository)
        {
            
            interviewRepository = _interviewRepository;
           
        }
        public bool ScheduleInterview(Interview interview)
        {
            interviewRepository.ScheduleInterview(interview);
            return true;
        }
        public List<Interview> GetInterviews()
        {
            return interviewRepository.GetInterviews();
        }

    }
}
