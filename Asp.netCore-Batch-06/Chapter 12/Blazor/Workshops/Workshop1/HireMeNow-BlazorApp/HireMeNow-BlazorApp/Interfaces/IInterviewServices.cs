using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IInterviewServices
	{
		Interview sheduleinterview(Interview interview);
		List<Interview> sheduledInterviewList(Guid cmpid);
		void removeInterview(Guid id);

	}
}
