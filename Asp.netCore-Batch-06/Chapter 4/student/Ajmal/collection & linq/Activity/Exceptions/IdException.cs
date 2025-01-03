using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Exceptions
{
    public class IdException:Exception
    {
        public IdException()
        :base(string.Format("Invalid Id Format")){
            
        }
    }
}
