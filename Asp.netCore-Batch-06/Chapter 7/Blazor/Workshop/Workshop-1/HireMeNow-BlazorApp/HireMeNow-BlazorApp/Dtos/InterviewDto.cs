namespace HireMeNow_BlazorApp.Dtos
{
	public class InterviewDto
	{
		public Guid Id { get; set; }
		public Guid JobId { get; set; }
		public string Company { get; set; }
		public string Post { get; set; }
		public DateTime Date { get; set; }
		public string Location { get; set; }
		public DateTime Time { get; set; }

		public InterviewDto(Guid jobId,string company, string post, DateTime date, string location, DateTime time)
		{
			Id = Guid.NewGuid();
			  JobId = jobId;
			Company = company;
			Post = post;
			Date = date;
			Location = location;
			Time = time;
		}
		public InterviewDto()
		{

		}
	}
}
