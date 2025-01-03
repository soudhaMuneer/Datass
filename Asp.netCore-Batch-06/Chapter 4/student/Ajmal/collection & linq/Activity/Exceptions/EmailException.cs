using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Exceptions
{
    public class EmailException:Exception
    {
        public EmailException()
         : base(string.Format("Invalid Mail Format")) { }
    }
}
