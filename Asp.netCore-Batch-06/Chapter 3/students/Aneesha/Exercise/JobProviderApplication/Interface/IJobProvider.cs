using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Interface
{
    internal interface IJobProvider
    {
       
       public void PostJob();
       public void GetJob();
    }
}
