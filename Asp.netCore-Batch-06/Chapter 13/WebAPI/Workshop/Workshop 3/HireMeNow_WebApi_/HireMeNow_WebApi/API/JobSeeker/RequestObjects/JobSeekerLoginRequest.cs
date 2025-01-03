﻿using System.ComponentModel.DataAnnotations;

namespace HireMeNow_WebApi.API.JobSeeker.RequestObjects
{
    public class JobSeekerLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
