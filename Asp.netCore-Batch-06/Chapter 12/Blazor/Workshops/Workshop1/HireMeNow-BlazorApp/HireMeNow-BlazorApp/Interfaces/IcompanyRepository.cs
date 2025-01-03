using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
    public interface ICompanyRepository
    {
        //List<Company> getAllCompanies(string? name);
        Company? getById(Guid id);
        Company? Register(Company company);
        Company Update(Company company);


	}
}
