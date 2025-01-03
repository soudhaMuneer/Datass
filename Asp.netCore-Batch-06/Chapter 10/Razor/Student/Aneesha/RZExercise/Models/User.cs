using System;
using System.Collections.Generic;

namespace RZExercise.Models;

public partial class User
{
    public Guid UserId { get; set; }

    public string? UserName { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Gender { get; set; }

    public string? Location { get; set; }

    public string? Phone { get; set; }

    public string? Qualification { get; set; }

    public virtual ICollection<Apply> Applies { get; set; } = new List<Apply>();
}
