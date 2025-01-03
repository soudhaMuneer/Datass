using System;
using System.Collections.Generic;

namespace Mvc_Pet_App_StoredProcedure.Models;

public partial class PetCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
