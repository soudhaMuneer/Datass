using System;
using System.Collections.Generic;

namespace StudentEF.Model;

public partial class Grade
{
    public Guid Id { get; set; }

    public string Grade1 { get; set; } = null!;

    public virtual ICollection<Studentlist> Studentlists { get; } = new List<Studentlist>();
}
