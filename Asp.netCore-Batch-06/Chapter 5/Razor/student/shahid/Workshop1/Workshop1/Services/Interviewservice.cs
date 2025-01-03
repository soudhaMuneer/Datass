using Workshop1.Reprosetry;

namespace Workshop1.Services
{
    public class Interviewservice
    {
        InterviewRepository interviewRepository = new InterviewRepository();
        public List<Interview> GetInterviews()
        {
            return interviewRepository.GetInterviews();
        }

        public bool ScheduleInterview(Interview interview)
        {
            interviewRepository.ScheduleInterview(interview);

            return true;
        }
    }
}
