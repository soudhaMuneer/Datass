using System;
using System.Collections.Generic;

namespace RZExercise.Models;

public partial class Job
{
    public Guid JobId { get; set; }

    public string? JobTitle { get; set; }

    public string? Description { get; set; }

    public string? Location { get; set; }

    public DateTime? PostedDate { get; set; }

    public virtual ICollection<Apply> Applies { get; set; } = new List<Apply>();
}
