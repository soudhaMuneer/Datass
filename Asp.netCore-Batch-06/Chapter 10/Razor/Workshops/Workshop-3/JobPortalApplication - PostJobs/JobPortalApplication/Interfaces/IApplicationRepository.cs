﻿using JobPortalApplication.Models;

namespace JobPortalApplication.Interfaces
{
	public interface IApplicationRepository
	{
		public List<Application> GetAll(Guid userId);
		public void AddApplication(User user, Job job);
		List<Application> GetAllApplication(Guid companyid);
		Application GetAllApplicationById(Guid id);
	}
}
