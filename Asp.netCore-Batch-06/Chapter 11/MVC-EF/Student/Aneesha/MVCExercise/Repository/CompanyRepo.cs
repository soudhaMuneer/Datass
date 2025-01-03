using MVCExercise.Interface;
using MVCExercise.Models;

namespace MVCExercise.Repository
{
    public class CompanyRepo : ICompanyRepo
    {
        CompanyControllerContext _controllerContext = new CompanyControllerContext();
        public CompanyRepo(CompanyControllerContext controllerContext)
        {
            _controllerContext = controllerContext;
        }
        public Company Registration(Company company)
        {
            _controllerContext.Companies.Add(company);
            _controllerContext.SaveChanges();
            return company;
        }
        public List<Company> ViewCompanyProfile(Company company)
        {
            return _controllerContext.Companies.ToList();
        }
        public Company GetCompanyById(int id)
        {
            return _controllerContext.Companies.Where(e => e.CompanyId == id).FirstOrDefault();
        }
    }
}