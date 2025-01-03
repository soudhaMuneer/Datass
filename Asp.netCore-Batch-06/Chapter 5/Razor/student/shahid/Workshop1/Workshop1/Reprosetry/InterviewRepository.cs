using Workshop1.Interface;

namespace Workshop1.Reprosetry
{
    public class InterviewRepository : Iinterview
    {
        public InterviewRepository() { }
        private static List<Interview> interviews = new List<Interview> { new Interview("Tcs","developer","12-02-2023", "Thrissur","12pm") };
        public bool ScheduleInterview(Interview interview)
        {
            var Id = interviews.Count + 1;
            interview.Id = Id;
            interviews.Add(interview);
            return true;
        }
        public List<Interview> GetInterviews()
        {
            return interviews;
        }
    }
}
