using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface ICompanyService
    {

        public List<User> memberListing(Guid companyId);
      
       
     
        List<Company> GetAllCompany(string? name=null);
        Company? getCompanyById(Guid? value=null);

    }
}
