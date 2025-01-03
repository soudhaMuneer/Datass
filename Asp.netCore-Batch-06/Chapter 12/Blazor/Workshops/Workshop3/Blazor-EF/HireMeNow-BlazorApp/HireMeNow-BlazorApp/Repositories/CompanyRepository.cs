using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Exceptions;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using Mvc_HireMeNow.Models;

namespace HireMeNow_BlazorApp.Repositories
{
    public class CompanyRepository : ICompanyRepository

    {
        HireMeNowDbContext _context=new HireMeNowDbContext();

        //private List<Company> companies = new List<Company> { new Company("Aitrich","aitrich@gmail.com","www.aitrich.com","7654643632",null,"IT Training and consultancy service .","To Guid Students to Future of web development","","Thrissur",new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5") )};
        public CompanyRepository(HireMeNowDbContext context)
        {
            _context = context;
        }



        //public List<Company> getAllCompanies(string? name)
        //{
        //    if(name == null)    
        //    return companies;
        //    else return companies.Where(e=>e.Name.Contains(name,StringComparison.OrdinalIgnoreCase)).ToList();
        //}

        public Company? getById(Guid id)
        {
            return _context.Companies.Where(c => c.Id == id).FirstOrDefault();
        }

        public Company? Register(Company company)
        {
            company.Id=Guid.NewGuid();
           _context.Companies.Add(company);
            _context.SaveChanges();
            return company;
        }


        public Company Update(Company company)
        {
            var companyToUpdate = _context.Companies.FirstOrDefault(u => u.Id == company.Id);
            if (companyToUpdate !=null)
            {
                // Modify the properties of the item at the found index
                companyToUpdate.About = company.About ?? companyToUpdate.About;

                companyToUpdate.Name = company.Name ?? companyToUpdate.Name;
                companyToUpdate.Email = company.Email ?? companyToUpdate.Email;
                companyToUpdate.Website = company.Website ?? companyToUpdate.Website;
                companyToUpdate.Vision = company.Vision ?? companyToUpdate.Vision;
                companyToUpdate.Mission = company.Mission ?? companyToUpdate.Mission;
                companyToUpdate.Location = company.Location ?? companyToUpdate.Location;
                companyToUpdate.Address = company.Address ?? companyToUpdate.Address;
                //companies[indexToUpdate].Image = company.Address??companies[indexToUpdate].Address;
                companyToUpdate.Phone = company.Phone == null ? companyToUpdate.Phone : company.Phone;
                // companyToUpdate.Image = company.Image ?? companyToUpdate.Image;
                // companyToUpdate.ImageData = company.ImageData ?? companies[indexToUpdate].ImageData;

                _context.SaveChanges();
                return companyToUpdate;
            }
            else
            {
                throw new NotFoundException("Company Not Found");
            }

            return companyToUpdate;
        }
    }
}
