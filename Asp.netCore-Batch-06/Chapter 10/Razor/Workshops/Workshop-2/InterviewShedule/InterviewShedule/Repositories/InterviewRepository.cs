
using InterviewShedule.Interfaces;
using InterviewShedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewShedule.Repositories
{
    public class InterviewRepository: IInterviewProvider
    {
        private static InterviewRepository instance = null;
        private static readonly object padlock = new object();

        InterviewRepository() { }
        public static InterviewRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new InterviewRepository();
                    }
                    return instance;
                }
            }
        }
        private List<Interview> interviews = new List<Interview> { new Interview("Tcs","developer","12-02-2023", "Thrissur","12pm") };
        public bool ScheduleInterview(Interview interview)
        {
           var Id= interviews.Count + 1;
            interview.Id= Id;
            interviews.Add(interview);
            return true;

        }

        public List<Interview> GetInterviews()
        {
            return interviews;
        }
    }
}
