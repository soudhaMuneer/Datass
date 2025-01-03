using Admin_Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Portal.Interface
{
    public interface IJobRepository
    {
        //bool Newjob(Job job);
        List<Job> Getjob();
       
    }
}
