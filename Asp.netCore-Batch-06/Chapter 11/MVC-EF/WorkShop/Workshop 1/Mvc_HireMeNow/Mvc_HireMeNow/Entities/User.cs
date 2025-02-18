﻿using Mvc_HireMeNow.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_HireMeNow.Models;
[Index(nameof(Email), IsUnique = true)]
public partial class User
{
	[Key]
	[Required]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Guid Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Location { get; set; }

    public string? Phone { get; set; }

    public string password { get; set; }
    [Compare("password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
    public Roles? Role { get; set; }

    public string? About { get; set; }

    public string? Designation { get; set; }

    [ForeignKey(nameof(Company))]
    public Guid? CompanyId { get; set; } = null;

    public string? Status { get; set; }

    public byte[]? Image { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual Company? Company { get; set; }

    public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();

    public virtual ICollection<Interview> InterviewCreatedByNavigations { get; set; } = new List<Interview>();

    public virtual ICollection<Interview> InterviewJobseekers { get; set; } = new List<Interview>();

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
