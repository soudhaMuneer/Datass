using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database_connection.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }
  
    public int? GradeId { get; set; }

    public virtual Grade? Grade { get; set; }
}
