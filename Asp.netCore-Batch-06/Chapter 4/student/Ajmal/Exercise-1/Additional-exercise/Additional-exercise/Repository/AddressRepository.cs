using Additional_exercise.Interface;
using Additional_exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_exercise.Repository
{
    public class AddressRepository:IAddress
    {
        int add = 5;
        public static List<Country> All = new List<Country>();
        public bool Address(Country address)
        {
            address.Id = add;
            add++;
            All.Add(address);
            return true;
        }
        public List<Country> GetAddress()
        {
            return All;
        }
    }
}
