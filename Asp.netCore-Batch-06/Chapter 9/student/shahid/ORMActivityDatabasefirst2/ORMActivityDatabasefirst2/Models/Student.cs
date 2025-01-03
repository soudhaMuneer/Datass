using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORMActivityDatabasefirst2.Models;

public partial class Student
{
    public int Studentid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }
    [ForeignKey(nameof(Grade))]
    public int? Gradeid { get; set; }

    public virtual Grade? Grade { get; set; }
}
