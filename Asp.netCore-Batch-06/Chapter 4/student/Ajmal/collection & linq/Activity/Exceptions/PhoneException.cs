using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Exceptions
{
    public class PhoneException:Exception
    {
        public PhoneException()
            : base(string.Format("Invalid Mail Format"))
        { }
    }
}
