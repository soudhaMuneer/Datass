using System;
using System.Collections.Generic;

namespace MVCExercise.Models;

public partial class CompanyMember
{
    public int MemberId { get; set; }

    public int? CompanyId { get; set; }

    public string? MemberFirstName { get; set; }

    public string? MemberLastName { get; set; }

    public string? MemberEmail { get; set; }

    public string? MemberPassword { get; set; }

    public string? ConfirmPassword { get; set; }

    public string? MemberPhoneNumber { get; set; }

    public string? Designation { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public virtual Company? Company { get; set; }
}
