using RazorExercise.Enums;

namespace RazorExercise.Models
{
	public class Job
	{
		public int Id { get; set; }
		public string Jobtitle { get; set; }
		public string Company { get; set; }
		//public string jobtype { get; set; }

		public string Description { get; set; }
		public string Date { get; set; }
		public string Location { get; set; }
		public string image {  get; set; }
		public Job(int id, string jobtitle, string company,string image, string description, string date, string location)
		{
			Id = id;
			Jobtitle = jobtitle;
			Company = company;
			this.image=image;
			Description = description;
			Date = date;
			Location = location;
			
		}
		public Job() { }
	}
}
