using Additional_exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_exercise.Interface
{
    public interface IAddress
    {
        bool Address(Country address);
        List<Country> GetAddress();
    }
}
