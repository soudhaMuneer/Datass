using System;
using System.Collections.Generic;

namespace ORMActivityDatabasefirst2.Models;

public partial class Grade
{
    public int Gradeid { get; set; }

    public string? Gradename { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
