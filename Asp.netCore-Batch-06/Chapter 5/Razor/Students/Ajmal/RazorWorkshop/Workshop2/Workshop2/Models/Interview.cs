namespace Workshop2.Models
{
	public class Interview
	{
		public Guid Id { get; set; }
		//public string JobTitle { get; set; }
		public string Job { get; set; }
		public string date { get; set; }
		public string time { get; set; }
		public string Location { get; set; }
		public Interview(Guid id, string job, string date, string time, string location)
		{
		Id = id;
			Job = job;
			this.date = date;
			this.time = time;
			Location = location;
		}
		public Interview() { }
	}
}
