using System;
using System.Collections.Generic;

namespace RZExercise.Models;

public partial class Interview
{
    public Guid InterviewId { get; set; }

    public Guid ApplyId { get; set; }

    public TimeOnly? InterviewTime { get; set; }

    public DateOnly? InterviewDate { get; set; }

    public string? InterviewNotes { get; set; }

    public virtual Apply? Apply { get; set; }
}
