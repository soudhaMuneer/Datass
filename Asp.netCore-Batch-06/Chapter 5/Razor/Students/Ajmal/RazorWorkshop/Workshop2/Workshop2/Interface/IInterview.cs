using Workshop2.Models;

namespace Workshop2.Interface
{
	public interface IInterview
	{
		bool SheduleInterview(Interview interview);
		List<Interview> Interviews();
	}
}
