using InterviewShedule.Interfaces;
using InterviewShedule.Models;
using InterviewShedule.Repositories;

namespace InterviewShedule.Services
{
	public class InterviewService : IInterviewProvider

	{
        InterviewRepository interviewRepository = InterviewRepository.Instance;

        //private List<Interview> interviews = new List<Interview>();
		public List<Interview> GetInterviews()
		{
		return	interviewRepository.GetInterviews();
		}

		public bool ScheduleInterview(Interview interview)
		{
            interviewRepository.ScheduleInterview(interview);

			return true;
		}
	}
}
