using System;
using System.Collections.Generic;

namespace MVCExercise.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyEmail { get; set; }

    public string? CompanyWebsite { get; set; }

    public string? CompanyPhoneNumber { get; set; }

    public string? CompanyLocation { get; set; }

    public string? Vision { get; set; }

    public string? About { get; set; }

    public virtual ICollection<CompanyMember> CompanyMembers { get; set; } = new List<CompanyMember>();
}
