using System;
using System.Collections.Generic;

namespace RZWorkshop.Models;

public partial class Companiess
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? Phone { get; set; }

    public string? Logo { get; set; }

    public string? About { get; set; }

    public string? Vision { get; set; }

    public string? Mission { get; set; }

    public string? Location { get; set; }

    public string? Address { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Applicationss> Applicationsses { get; set; } = new List<Applicationss>();

    public virtual ICollection<Interviewss> Interviewsses { get; set; } = new List<Interviewss>();

    public virtual ICollection<Jobss> Jobsses { get; set; } = new List<Jobss>();

    public virtual ICollection<Userss> Usersses { get; set; } = new List<Userss>();
}
