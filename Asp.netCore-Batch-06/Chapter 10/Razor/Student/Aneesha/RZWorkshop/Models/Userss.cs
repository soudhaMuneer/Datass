using System;
using System.Collections.Generic;

namespace RZWorkshop.Models;

public partial class Userss
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public string? Location { get; set; }

    public string? Phone { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }

    public string? About { get; set; }

    public string? Designation { get; set; }

    public int? CompanyId { get; set; }

    public string? Status { get; set; }

    public string? Image { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Applicationss> Applicationsses { get; set; } = new List<Applicationss>();

    public virtual Companiess? Company { get; set; }

    public virtual ICollection<Interviewss> InterviewssCreatedByNavigations { get; set; } = new List<Interviewss>();

    public virtual ICollection<Interviewss> InterviewssJobSeekers { get; set; } = new List<Interviewss>();

    public virtual ICollection<Jobss> Jobsses { get; set; } = new List<Jobss>();

    public virtual ICollection<Qualificationss> Qualificationsses { get; set; } = new List<Qualificationss>();

    public virtual ICollection<Skillss> Skillsses { get; set; } = new List<Skillss>();
}
