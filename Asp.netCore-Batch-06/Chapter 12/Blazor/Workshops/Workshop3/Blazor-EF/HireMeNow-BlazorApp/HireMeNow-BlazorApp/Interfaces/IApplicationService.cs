﻿
using HireMeNow_BlazorApp.Models;
namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IApplicationService
	{
       
		public void AddApplication(Guid userId, Guid jobId);
		public List<Application> GetAllByCompany(Guid companyId);
    }
}
