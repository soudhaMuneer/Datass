using CollectionActivity;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace CollectionActivity
{
    class CollectionActivity
    {

        static void Main(string[] args)
        {


            Queue jobs = new Queue();
            jobs.Enqueue("PHP dev");
            jobs.Enqueue("dot net dev");
            jobs.Enqueue("Python dev");
            Console.WriteLine(jobs.Peek());
            while(jobs.Count > 0)
            {
                Console.WriteLine(jobs.Dequeue());
            }

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add("one");

            //foreach (var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            /////////////////////////////////////////////////////////////////////////////

            //Dictionary<int, string> Details = new Dictionary<int, string>();

            //Details.Add(1, "Sunday");
            //Details.Add(2, "Monday");
            //Details.Add(3, "Tuesday");
            //Details.Add(4, "Wednesday");
            //Details.Add(5, "Thursday");
            //Details.Add(6, "Friday");
            //Details.Add(7, "Saturrday");

            //foreach (KeyValuePair<int, string> items in Details)
            //{
            //    Console.WriteLine($"{items.Key} : {items.Value}");
            //}

            //var getDayByletter = Details.Where(s => s.Value.Contains("M"));

            //foreach (var day in getDayByletter)
            //{
            //    Console.WriteLine(day);
            //}

            ////////////////////////////////////////////////////////////////////////////

            List<JobSeeker> list = new List<JobSeeker>();

            int Count = 0;
            int Id = 0;

            Console.WriteLine("How User you want to Register");
            int a = Convert.ToInt32(Console.ReadLine());

            do
            {
                JobSeeker seek = new JobSeeker();

                Console.WriteLine("****************************************");
                Console.WriteLine("Enter Id");
                seek.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a name");
                seek.Name = Console.ReadLine();

                Console.WriteLine("Enter Email");
                seek.Email = Console.ReadLine();

                try
                {
                    Validator.ValidateEmail("example.com");
                }
                catch (InvalidEmailFormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Enter Phone Number");
                seek.Phone = Console.ReadLine();

                try
                {
                    Validator.ValidatePhoneNumber("1234567890");
                }
                catch (InvalidPhoneNumberLengthException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Enter City");
                seek.City = Console.ReadLine();

                list.Add(seek);
                Count++;

            } while (Count != a);

            Console.WriteLine("Registered Users");
            foreach (var seekers in list)
            {
                Console.WriteLine($" Name : {seekers.Name}");
                Console.WriteLine($" Email : {seekers.Email}");
                Console.WriteLine($" Phone : {seekers.Phone}");
                Console.WriteLine($" City : {seekers.City}");

                Console.WriteLine("****************************************");
            }

            Console.WriteLine("Enter renter Id");
            string id = Console.ReadLine();

            try
            {
                int renterId = int.Parse(id);
                Console.WriteLine("Renter ID: " + renterId);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Renter");
            }
            

            ////LinQ

            //var UserProfile = list.Where(s => s.Id == 2);

            //Console.WriteLine("Details of User By getting ID ");
            //Console.WriteLine("******************************");
            //foreach (var seeker in UserProfile)
            //{
            //    Console.WriteLine(seeker.Id);
            //    Console.WriteLine(seeker.Name);
            //    Console.WriteLine(seeker.Email);
            //    Console.WriteLine(seeker.Phone);
            //    Console.WriteLine(seeker.City);
            //}

            //var User = list.Where(s => s.Name.Contains("A"));

            //Console.WriteLine("Details of User By Letter ");
            //Console.WriteLine("******************************");

            //foreach (var seeker in User)
            //{
            //    Console.WriteLine(seeker.Name);
            //}

            //var order = list.OrderBy(s => s.Name);

            //Console.WriteLine("Details of User By order name ");
            //Console.WriteLine("******************************");

            //foreach (var seeker in order)
            //{
            //    Console.WriteLine(seeker.Id);
            //    Console.WriteLine(seeker.Name);
            //    Console.WriteLine(seeker.Email);
            //    Console.WriteLine(seeker.Phone);
            //    Console.WriteLine(seeker.City);
            //}


            //var Group = list.GroupBy(s => s.City);

            //Console.WriteLine(" Classify by Same City ");
            //Console.WriteLine("******************************");

            //foreach (var Citygrp in Group)
            //{
            //    Console.WriteLine($"Same Cities : {Citygrp.Key}");

            //    foreach (var group in Citygrp)
            //    {
            //        Console.WriteLine($"User Name: {group.Name}");
            //    }
            //}

            ///////////////////////////////////////////////////////////
            ///

            //stack

            //Stack stack = new Stack();

            //stack.Push("Google");
            //stack.Push("Meta");
            //stack.Push("Microsoft");
            //stack.Push("Nvidia");

            //Console.WriteLine("Added Element : ");
            //foreach(var i in stack)
            //{
            //    Console.WriteLine(i);
            //}

            //stack.Pop();
            //Console.WriteLine("After Removing Element : ");

            //foreach (var i in stack)
            //{
            //    Console.WriteLine(i);
            //}


            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    string a = Console.ReadLine();
            //}
            //catch(FormatException) 
            //{
            //  Console.WriteLine("please enter number");
            //}

            ////////////////////////////custom exception////////////////////



        }
        
    }

}