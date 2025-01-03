using System;
using System.Net.Mail;
using System.Collections;
using Activity.Models;
using System.Text.RegularExpressions;
using Activity.Exceptions;
using System.Linq;
namespace MyApp
{
    public class Program
    {
      
       public static void Main(string[] args)
        {
            Jobseeker jobseeker = new Jobseeker();
            List<object> list = new List<object>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("one");
            foreach (object obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Sunday");
            dict.Add(2, "Monday");
            dict.Add(3, "Tuesday");
            dict.Add(4, "Wednesday");
            dict.Add(5, "Thursday");
            dict.Add(6, "Friday");
            dict.Add(7, "Saturday");

            List<Jobseeker> jobs = new List<Jobseeker>();
            int count=Convert.ToInt32(Console.ReadLine());
            int n = 0;
            
            while (n!=count)
            {


                Jobseeker newJobSeeker = new Jobseeker();
                newJobSeeker.id= id();
                Console.WriteLine("Name");
                newJobSeeker.name = Console.ReadLine();
                newJobSeeker.Email= mail();
                newJobSeeker.Mobile= phone();
               
                Console.WriteLine("City");
                newJobSeeker.City = Console.ReadLine();

               

                jobs.Add(newJobSeeker);
                n++;
            }



            string[] names = { "Bill", "Steve", "Jame", "Mohan","shemem","shahid" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;


            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name + " ");
            }
            var assending = jobs.OrderBy(s => s.name);
            foreach (var job in assending)
            {
                Console.WriteLine(job.name + " ");
            }
            Console.WriteLine("print datas with id :");
            int num = Convert.ToInt32(Console.ReadLine());
            var lin = jobs.Where(s => s.id == num);
            foreach (var job in lin)
            {
                Console.WriteLine(job.id);
                Console.WriteLine(job.name + " ");
                Console.WriteLine(job.Email );
                Console.WriteLine(job.Mobile + " ");
                Console.WriteLine(job.City + " ");

            }
            Console.WriteLine("print datas with name :");
            string num1 =Console.ReadLine();
            var lin1 = jobs.Where(s => s.name == num1);
            foreach (var jo in lin1)
            {
                Console.WriteLine(jo.id);
                Console.WriteLine(jo.name + " ");
                Console.WriteLine(jo.Email);
                Console.WriteLine(jo.Mobile + " ");
                Console.WriteLine(jo.City + " ");

            }

            var linq1 = dict.Where(m => m.Key.ToString().Contains("3"));
            foreach(var name in linq1)
            {
                Console.WriteLine(name + " ");
            }

            var mylinq = list.OfType<string>().Where(w=> w.Contains("o")) ;
            foreach (var name in mylinq)
            {
                Console.WriteLine(name + " ");
            }

            var group = from s in jobs
                        group s by s.City;
             foreach(var name in group)
            {
                Console.WriteLine("Place : {0}", name.Key);
                foreach(var s in name)
                {
                    Console.WriteLine("Student Name : {0}", s.name);
                }
            }         

            
            int id()
            {
                try
                {
                    Console.WriteLine("Id");
                    int Id= Convert.ToInt32(Console.ReadLine());
                    //var idformat = "^\\d{1}$";
                    //Regex rg2 = new Regex(idformat);
                    //if (!rg2.IsMatch(jobseeker.id))
                    //{
                    //    throw new IdException();

                    //}

                    return Id;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Format");
                    return id();
                }
            }
            string mail()
            {
                try
                {
                    
                    Console.WriteLine("mail");
                    string Email = Console.ReadLine();
                    var mailformat = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
                    Regex rg = new Regex(mailformat);
                    if (!rg.IsMatch(Email))
                    {
                        throw new EmailException();
                       
                    }
                    return Email;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return mail();
                }
            }
            string phone()
            {
                try { 
                Console.WriteLine("phone");
                string Mobile = Console.ReadLine();
                var phoneformat = "^\\d{10}$";

                Regex rg1 = new Regex(phoneformat);

                if (!rg1.IsMatch(Mobile))
                {
                    throw new PhoneException();

                }
                    return Mobile;
                }
                catch (Exception ex)
                {
                Console.WriteLine(ex.Message);
               return phone();
            }
        }
            



        }
       
       
        
    }
}

