﻿using MVCWorkshop.Enums;
using System;
using System.Collections.Generic;

namespace MVCWorkshop.Models;

public partial class User
{
    public Guid Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Location { get; set; }

    public string? Phone { get; set; }

    public string? Password { get; set; }

    public Roles? Role { get; set; }

    public string? About { get; set; }

    public string? Designation { get; set; }

    public Guid? CompanyId { get; set; }

    public string? Status { get; set; }

    public string? Image { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual Company? Company { get; set; }

    public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();

    public virtual ICollection<Interview> InterviewCreatedByNavigations { get; set; } = new List<Interview>();

    public virtual ICollection<Interview> InterviewJobseekers { get; set; } = new List<Interview>();

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
