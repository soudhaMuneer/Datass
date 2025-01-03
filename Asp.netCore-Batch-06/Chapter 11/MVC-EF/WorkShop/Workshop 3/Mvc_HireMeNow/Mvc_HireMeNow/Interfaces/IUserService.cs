using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
	public interface IUserService
	{

        public User getById(Guid userId);

    }
}
