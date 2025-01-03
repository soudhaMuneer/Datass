using System;
using System.Collections.Generic;

namespace RZWorkshop.Models;

public partial class Interviewss
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? JobId { get; set; }

    public int? JobSeekerId { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public string? Location { get; set; }

    public string? Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual Companiess? Company { get; set; }

    public virtual Userss? CreatedByNavigation { get; set; }

    public virtual Jobss? Job { get; set; }

    public virtual Userss? JobSeeker { get; set; }
}
