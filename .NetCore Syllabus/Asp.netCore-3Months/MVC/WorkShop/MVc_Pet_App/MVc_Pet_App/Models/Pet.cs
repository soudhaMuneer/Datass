using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVc_Pet_App.Models;

public partial class Pet
{

	public Guid Id { get; set; }
	public string? Name { get; set; }
	public int Age { get; set; }
	public string? Gender { get; set; }
	public string Discription { get; set; } = null!;
	public string? Image { get; set; }
	public string? Location { get; set; }


}
