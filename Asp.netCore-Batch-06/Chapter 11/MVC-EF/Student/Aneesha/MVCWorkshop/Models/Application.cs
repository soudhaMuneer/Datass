using System;
using System.Collections.Generic;

namespace MVCWorkshop.Models;

public partial class Application
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? CompanyId { get; set; }

    public DateOnly? AppliedDate { get; set; }

    public string? Status { get; set; }

    public virtual Company? Company { get; set; }

    public virtual Job? Job { get; set; }

    public virtual User? User { get; set; }
}
