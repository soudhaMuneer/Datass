using activity;
using System;
using System.Collections;


namespace MyApp
{
    public class Program
    {   
        static void Main(string[] args)
        {
            Dictionary <int,string> dictionary = new Dictionary<int,string>();
            ArrayList arrayList = new ArrayList();
            List<JobSeeker> list = new List<JobSeeker>();
            //adding to dictionary
            dictionary.Add(0, "sunday");
            dictionary.Add(1, "monday");
            dictionary.Add(2, "tuesday");
            dictionary.Add(3, "wedsday");
            dictionary.Add(4, "thursday");
            dictionary.Add(5, "friday");
            dictionary.Add(6, "saturday");
            list.Add(new JobSeeker() { "","","","","",""});


        }
    }
}