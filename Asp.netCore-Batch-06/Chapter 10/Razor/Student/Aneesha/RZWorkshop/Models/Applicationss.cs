using System;
using System.Collections.Generic;

namespace RZWorkshop.Models;

public partial class Applicationss
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? JobId { get; set; }

    public int? CompanyId { get; set; }

    public DateOnly? AppliedDate { get; set; }

    public string? Status { get; set; }

    public virtual Companiess? Company { get; set; }

    public virtual Jobss? Job { get; set; }

    public virtual Userss? User { get; set; }
}
