﻿using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Managers;
using HireMeNow_MVC_Application.Models;
using HireMeNow_MVC_Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_MVC_Application.Controllers
{
    public class AdminController : Controller
    {
		private readonly IAdminService _adminService;
		private readonly IJobService _jobService;
		public AdminController(IJobService jobService, IAdminService adminService)
		{
			_jobService = jobService;
            _adminService = adminService;
        }
		string uid;
       
        public User loggedUser;
        public IActionResult Edit()
        {
            User user = _adminService.getLoggedUser();
            if (user.Email != null)
            {
                return View(user);
                //uid = HttpContext.Session.GetString("UserId");

                //if (uid != null)
                //{
                //    loggedUser = _adminService.GetUserById(new Guid(uid));
                //    return View(loggedUser);
                //}
                //else
                //{
                //    return RedirectToPage("Edit");
                //}
                //return View();
            }
            //User adminToUpdate = adminList.FirstOrDefault(a => a.Email == Email);

            return View(loggedUser);
        }
        [HttpPost]
        public IActionResult Edit(User updatedAdmin)
        {

            uid = HttpContext.Session.GetString("UserID");
          if (uid != null)
            {
                _adminService.UpdateProfile(updatedAdmin);
                TempData["messag"] = "Updated successfully";
            }
            return RedirectToAction("JobSeekerListing");
        }
        
		
		public IActionResult JobList()
		{
			List<Job> joblist = _jobService.GetJobs();
			return View("joblist", joblist);
		}
        public ActionResult JobSeekerListing()
        {
            try
            {
                List<User> jobseekers = _adminService.JobSeekerListing();

                return View(jobseekers);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }


}

