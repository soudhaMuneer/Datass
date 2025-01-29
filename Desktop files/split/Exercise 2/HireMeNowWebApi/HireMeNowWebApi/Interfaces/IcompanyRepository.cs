using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface ICompanyRepository
    {
        List<Company> getAllCompanies(string? name);
        Company? getById(Guid? id=null);
       
    }
}
