using Workshop2.Interface;
using Workshop2.Models;
using Workshop2.Repository;

namespace Workshop2.Services
{
	public class Interviewslisting:IInterview
	{
		public  InterviewRepository interviewRepository = new InterviewRepository();
		public bool SheduleInterview(Interview interview)
		{
			interviewRepository.SheduleInterview(interview);
			return true;
		}
	public	List<Interview> Interviews()
		{
			return interviewRepository.Interviews();
		}
	}
}
