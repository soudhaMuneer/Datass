using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using HireMeNow_BlazorApp.Repositories;

namespace HireMeNow_BlazorApp.Services
{
	public class InterviewServices : IInterviewServices
	{
		public IInterviewRepository interviewRepository;

		public InterviewServices(IInterviewRepository interviewRepository)
		{
			this.interviewRepository = interviewRepository;
		}

		public void removeInterview(Guid id)
		{
			interviewRepository.removeInterview(id);
		}

		public List<Interview> sheduledInterviewList(Guid cmpid)
		{
			return interviewRepository.sheduledInterviewList(cmpid);
		}

		public Interview sheduleinterview(Interview interview)
		{
			return interviewRepository.shduleInterview(interview);
		}
	
	}
}
