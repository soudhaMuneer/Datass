using Workshop2.Interface;
using Workshop2.Models;

namespace Workshop2.Repository
{
	public class InterviewRepository : IInterview
	{
		public Guid InterviewId { get; set; } = Guid.NewGuid();
		public static List<Interview> interviews = new List<Interview> ();
		//{ new Interview("Aitrich","12/1/2010","12:00 pm","Thrissur")}
	public bool SheduleInterview(Interview interview)
		{
			
			interview.Id= InterviewId;
			interviews.Add(interview);
			return true;
		}
		public List<Interview> Interviews()
		{
			return interviews;
		}
		public InterviewRepository() { }
	}
}
