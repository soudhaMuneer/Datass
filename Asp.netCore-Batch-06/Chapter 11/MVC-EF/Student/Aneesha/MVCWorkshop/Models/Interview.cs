using System;
using System.Collections.Generic;

namespace MVCWorkshop.Models;

public partial class Interview
{
    public Guid Id { get; set; }

    public Guid? JobId { get; set; }

    public Guid? JobseekerId { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public string? Location { get; set; }

    public string? Status { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public Guid? CompanyId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Job? Job { get; set; }

    public virtual User? Jobseeker { get; set; }
}
