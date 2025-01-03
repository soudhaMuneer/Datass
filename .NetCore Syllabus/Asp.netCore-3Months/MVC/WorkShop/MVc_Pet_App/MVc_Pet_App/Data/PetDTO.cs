using System.ComponentModel.DataAnnotations.Schema;

namespace MVc_Pet_App.Data
{
	public class PetDTO
	{
		public string? Name { get; set; }
		public int Age { get; set; }
		public string? Gender { get; set; }
		public string Discription { get; set; } = null!;
		[NotMapped]
		public IFormFile Image { get; set; }
		public string? Location { get; set; }
	}
}
