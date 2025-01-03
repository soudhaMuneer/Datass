using System;
using System.Collections.Generic;

namespace RZWorkshop.Models;

public partial class Jobss
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Location { get; set; }

    public string? Experience { get; set; }

    public string? TypeOfWorkPlace { get; set; }

    public string? Salary { get; set; }

    public string? Responsibilities { get; set; }

    public string? JobType { get; set; }

    public string? VacanciesCount { get; set; }

    public int? AppliedCount { get; set; }

    public string? Status { get; set; }

    public int? CompanyId { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public virtual ICollection<Applicationss> Applicationsses { get; set; } = new List<Applicationss>();

    public virtual Companiess? Company { get; set; }

    public virtual Userss? CreatedByNavigation { get; set; }

    public virtual ICollection<Interviewss> Interviewsses { get; set; } = new List<Interviewss>();
}
