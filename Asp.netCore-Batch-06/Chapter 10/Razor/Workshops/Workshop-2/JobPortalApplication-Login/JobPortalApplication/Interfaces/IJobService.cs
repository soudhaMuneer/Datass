﻿using JobPortalApplication.Dtos;
using JobPortalApplication.Models;

namespace JobPortalApplication.Interfaces
{
    public interface IJobService
    {
        public Job PostJob(Job job);
        public List<Job> GetJobs();
        public Job getJobById(Guid selectedJobId);
		void DeleteItemById(Guid id);
		Job Update(Job job);
		List<Job> getByTitle(string title);
		//void DeleteItemById(Job jobToRemove);
	}
}
