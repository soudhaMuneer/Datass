using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IInterviewRepository
	{
		Interview shduleInterview(Interview interview);
		List<Interview> sheduledInterviewList(Guid cmpid);
		void removeInterview(Guid id);
		
	}
}
