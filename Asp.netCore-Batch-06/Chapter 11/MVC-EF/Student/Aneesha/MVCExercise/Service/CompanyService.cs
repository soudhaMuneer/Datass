using MVCExercise.Interface;
using MVCExercise.Models;

namespace MVCExercise.Service
{
    public class CompanyService : ICompanyService
    {
        ICompanyRepo companyrepo;

        public CompanyService(ICompanyRepo companyR)
        {
            companyrepo = companyR;
        }

        public Company Registration(Company company)
        {
            return companyrepo.Registration(company);
        }
        public List<Company> ViewCompanyProfile(Company company)
        {
            return  companyrepo.ViewCompanyProfile(company);
        }
        public Company GetCompanyById(int id)
        {
            return companyrepo.GetCompanyById(id);
        }
    }
}
