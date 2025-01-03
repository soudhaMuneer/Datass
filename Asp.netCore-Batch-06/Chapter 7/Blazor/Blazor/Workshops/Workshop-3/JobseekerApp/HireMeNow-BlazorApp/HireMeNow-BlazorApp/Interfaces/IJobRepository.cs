﻿using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
    public interface IJobRepository
    {
        Job PostJob(Job job);
		Job Update(Job job);
		List<Job> GetJobs();
		Job GetJobById(Guid selectedJobId);
		List<Job> GetJobsByIds(List<Guid> appliedJobsIds);
		

		void DeleteById(Guid id);
		List<Job> getByTitle(string title);
	}
}
