﻿using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Exceptions;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Repositories
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

        public Company? getById(Guid id)
        {
           return companies.Where(c=>c.Id == id).FirstOrDefault();
        }

        public Company? Register(Company company)
        {
            company.Id=Guid.NewGuid();
            companies.Add(company);
            return company;
        }


		public Company Update(Company company)
        {
            int indexToUpdate = companies.FindIndex(item => item.Id == company.Id);
            if (indexToUpdate != -1)
            {
                // Modify the properties of the item at the found index
                companies[indexToUpdate].About = company.About ?? companies[indexToUpdate].About;
                companies[indexToUpdate].Name = company.Name ?? companies[indexToUpdate].Name;
                companies[indexToUpdate].Email = company.Email ?? companies[indexToUpdate].Email;
                companies[indexToUpdate].Website = company.Website ?? companies[indexToUpdate].Website;
                companies[indexToUpdate].Vision = company.Vision??companies[indexToUpdate].Vision;
                companies[indexToUpdate].Mission = company.Mission??companies[indexToUpdate].Mission;
                companies[indexToUpdate].Location = company.Location??companies[indexToUpdate].Location;
                companies[indexToUpdate].Address = company.Address??companies[indexToUpdate].Address;
                //companies[indexToUpdate].Image = company.Address??companies[indexToUpdate].Address;
                companies[indexToUpdate].Phone = company.Phone==null ? companies[indexToUpdate].Phone : company.Phone;
                companies[indexToUpdate].Image = company.Image??companies[indexToUpdate].Image;
                companies[indexToUpdate].ImageData = company.ImageData??companies[indexToUpdate].ImageData;


            }
            else
            {
                throw new NotFoundException("Company Not Found");
            }

            return companies[indexToUpdate];
        }

    }
}
