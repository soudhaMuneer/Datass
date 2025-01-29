using HireMeNowWebApi.Exceptions;
using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private List<Company> companies = new List<Company> { new Company("Aitrich","aitrich@gmail.com","www.aitrich.com","7654643632",null,"IT Training and consultancy service .","To Guid Students to Future of web development","","Thrissur",new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5") )};
        public CompanyRepository() { }

        public List<Company> getAllCompanies(string? name)
        {
            if(name == null)    
            return companies;
            else return companies.Where(e=>e.Name.Contains(name,StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Company? getById(Guid? id=null)
        {
           return companies.Where(c=>c.Id == id).FirstOrDefault();
        }

        public Company? Register(Company company)
        {
            company.Id=Guid.NewGuid();
            companies.Add(company);
            return company;
        }

 
    }
}
