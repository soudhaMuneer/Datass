using System;
using System.Collections.Generic;

namespace StudentEF.Model;

public partial class Studentlist
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid Grade { get; set; }

    public virtual Grade GradeNavigation { get; set; } = null!;
}
