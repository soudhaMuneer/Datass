
using InterviewShedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewShedule.Interfaces
{
    public interface IInterviewProvider
    {
        bool ScheduleInterview(Interview interview);
        List<Interview> GetInterviews();
    }
}
