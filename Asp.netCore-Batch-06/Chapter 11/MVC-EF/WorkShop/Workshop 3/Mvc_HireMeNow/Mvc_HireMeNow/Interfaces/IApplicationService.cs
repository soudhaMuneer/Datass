
using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
	public interface IApplicationService
	{
	
		public void AddApplication(Guid userId, Guid jobId);
		
	}
}
