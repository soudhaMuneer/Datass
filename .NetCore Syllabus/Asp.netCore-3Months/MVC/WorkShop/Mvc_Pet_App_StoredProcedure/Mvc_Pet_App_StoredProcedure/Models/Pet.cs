using System;
using System.Collections.Generic;

namespace Mvc_Pet_App_StoredProcedure.Models;

public partial class Pet
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Location { get; set; }

    public int? Category { get; set; }
    public string? CategoryName { get; set; }
    public virtual PetCategory? CategoryNavigation { get; set; }
}
