

using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
    public interface IJobService
    {
		Job getJobById(Guid selectedJobId);

		public List<Job> GetJobs();

	}
}
