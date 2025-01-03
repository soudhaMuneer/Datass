using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Interface
{
    internal interface IInterviewProvider
    {
       public void ScheduleInterview();
       public void GetInterview();
    }
}
