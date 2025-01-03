// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace ConsoleApp3
{
    public class JobSeeker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
          

            List<JobSeeker> jobSeekers = new List<JobSeeker>();
            try
            {

                jobSeekers.Add(new JobSeeker { Id = 1, Name = "Heizel", Email = "heizel@gmail.com", Phone = "1234567890", City = "thrissur" });
                jobSeekers.Add(new JobSeeker { Id = 2, Name = "Ann", Email = "ann@gmail.com", Phone = "1234567890", City = "thrissur" });
                jobSeekers.Add(new JobSeeker { Id = 3, Name = "Roslin", Email = "roslin@gmail.com", Phone = "1234567890", City = "calicut" });



                Console.WriteLine("List of Job Seekers:");

                foreach (var jobSeeker in jobSeekers)
                {
                   
                    Console.WriteLine($"ID: {jobSeeker.Id}, Name: {jobSeeker.Name}, Email: {jobSeeker.Email}, Phone: {jobSeeker.Phone}, City: {jobSeeker.City}");
                    if (jobSeeker.Phone.Length!=10)
                    {
                        throw new Expect(jobSeeker.Phone);
                    }
                    else
                    {
                        Console.WriteLine("phone number valid");
                    }
                    if (IsValidEmail(jobSeeker.Email))
                    {
                        Console.WriteLine("Email is valid.");
                    }

                    else
                    {

                        throw new Emailexp(jobSeeker.Email);
                        Console.WriteLine("Email is not valid.");
                    }

                }
                    
                }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //LINQ using query
            var id3=from i in jobSeekers
                    where i.Id==3
                    select i;
            foreach (var item in id3)
            {
                Console.WriteLine($"{item.Id}  {item.Name} ");
            }
            //Linq using lambda expression name starts with A
            int count = jobSeekers.Count(x => x.Name.StartsWith("A"));
            Console.WriteLine("Name starts with A is:" + count);

            var newList=jobSeekers.OrderBy(x=>x.Name).ToList();
            foreach(var item in newList)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Email} {item.City} {item.Phone}");
            }
            //group by city
            var cityList=jobSeekers.GroupBy(x => x.City).OrderBy(newGroup=>newGroup.Key);
            foreach (var city in cityList)
            {
                Console.WriteLine($"Key:{city.Key}");
                foreach (var item in city)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Email} {item.City} {item.Phone}");
                }
            }
        }
        static bool IsValidEmail(string email)
        {
            // Regular expression for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}


