using System;
using System.Collections.Generic;

namespace RZExercise.Models;

public partial class Apply
{
    public Guid ApplyId { get; set; }

    public Guid UserId { get; set; }

    public Guid JobId { get; set; }

    public string? Resume { get; set; }

    public string? CoverLetter { get; set; }

    public DateTime? AppliedDate { get; set; }

    public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

    public virtual Job? Job { get; set; }

    public virtual User? User { get; set; }
}
