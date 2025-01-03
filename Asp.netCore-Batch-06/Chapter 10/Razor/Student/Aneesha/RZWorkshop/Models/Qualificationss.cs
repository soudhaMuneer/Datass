using System;
using System.Collections.Generic;

namespace RZWorkshop.Models;

public partial class Qualificationss
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Title { get; set; }

    public string? Mark { get; set; }

    public string? YearOfPassout { get; set; }

    public string? University { get; set; }

    public string? Status { get; set; }

    public virtual Userss? User { get; set; }
}
