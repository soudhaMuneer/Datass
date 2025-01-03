using Additional_exercise.Model;
using Additional_exercise.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_exercise.Service
{
    public class Addressbook:Person
    {
        
    public static AddressRepository addressRepository=new AddressRepository();
        public Addressbook() { }
        public void Newaddress()
        {
            Console.WriteLine("How much person you have to add the address-book");
            int inp= Convert.ToInt32(Console.ReadLine());
           int inp1 = 0;
            while (inp>inp1) {
                Country address = new Country();
                Console.WriteLine("Enter your FirstName : ");
                address.Name = Console.ReadLine();
                Console.WriteLine("Enter your LastName : ");
                address.lastname = Console.ReadLine();
                Console.WriteLine("Enter your Date-Of-Birth : ");
                address.Dateofbirth = Console.ReadLine();
                Console.WriteLine("Enter your Home-Address : ");
                address.HomeAddress = Console.ReadLine();
                Console.WriteLine("Enter your Work-Address : ");
                address.WorkAddress = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("---------------Enter your Address Details---------------");
                Console.WriteLine();
                Console.WriteLine("Enter your RoomNo : ");
                address.Roomnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Building : ");
                address.building = Console.ReadLine();
                Console.WriteLine("Enter your Street : ");
                address.street = Console.ReadLine();
                Console.WriteLine("Enter your City : ");
                address.city = Console.ReadLine();
                Console.WriteLine("Enter your Phone : ");
                address.phone = Console.ReadLine();
                Console.WriteLine("Enter your Email : ");
                address.email = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter your State Name : ");
                address.State = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter your Country Name : ");
                address.countryy = Console.ReadLine();
                addressRepository.Address(address);
                inp1++;
            }
            city();



        }
        public void city() 
        {
            var citygroup = from m in addressRepository.GetAddress()
                            group m by m.city;
            foreach(var city in citygroup)
            {
                Console.WriteLine("City : {0}", city.Key);
                foreach(var names in city)
                {
                    Console.WriteLine("Name : {0}", names.Name);
                }
            }
        }
        public void Country()
        {
            var citygroup = from m in addressRepository.GetAddress()
                            group m by m.countryy;
            foreach (var city in citygroup)
            {
                Console.WriteLine("Country : {0}", city.Key);
                foreach (var names in city)
                {
                    Console.WriteLine("Name : {0}", names.Name);
                }
            }
        }


    }
}
