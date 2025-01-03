﻿using Domain.Helpers;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminRepository
    {
        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();
        public Task<List<JobProviderCompany>> GetCompanies();

       


       

        public Task<List<Location>> GetLocations();

        public Task<List<JobPost>> GetJobs();

      
        public void DeleteById(Guid id);
        public void DeleteByLocationId(Guid id);
        public void DeleteCompaniesById(Guid id);

        public void DeleteByCategoryId(Guid id);

        public void DeleteByIndustryId(Guid id);

        public int GetCompanyCount();

        public int GetJobProviderCount();
        public Task<List<JobPost>> GetJobs(string JobLitle);

        public int GetJobCount();

        Task<bool> AddAsync(Skill skill);

        Task<bool> RemoveAsync(Guid skillId);


        Task<Location> addLocation(Location location);
        Task<List<JobProviderCompany>> SearchCompanies(string name);


    }

}
