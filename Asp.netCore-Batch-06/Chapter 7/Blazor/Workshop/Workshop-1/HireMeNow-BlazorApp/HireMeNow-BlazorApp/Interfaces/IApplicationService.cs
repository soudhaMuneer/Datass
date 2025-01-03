
using HireMeNow_BlazorApp.Models;
namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IApplicationService
	{
        public List<Application> GetAll(Guid userId);
        void AddApplication(Guid JobId, Guid UserId);
        public List<Application> GetAllByCompany(Guid companyId);
    }
}
