using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
    public interface ICompanyService
    {
      
        Company? Register(Company company);
    }
}
