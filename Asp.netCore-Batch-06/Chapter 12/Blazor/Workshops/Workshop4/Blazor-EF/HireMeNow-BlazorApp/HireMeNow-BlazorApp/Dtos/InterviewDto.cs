﻿namespace HireMeNow_BlazorApp.Dtos
{
	public class InterviewDto
	{
		public Guid Id { get; set; }
		public Guid JobId { get; set; }
		public Guid CompanyId { get; set; }
		public string Post { get; set; }
		public DateTime Date { get; set; }
		public string Location { get; set; }
		public string Time { get; set; }

		public InterviewDto(Guid jobId, Guid company, DateTime date, string location, string time)
		{
			Id = Guid.NewGuid();
			  JobId = jobId;
			CompanyId = company;
			//Post = post;
			Date = date;
			Location = location;
			Time = time;
		}
		public InterviewDto()
		{

		}
	}
}
