using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Models;

namespace Workshop.Manager

{
    internal class Admin
    {
       private User[] user = new User[5];
        private int count = 0;
        private JobManager job = new JobManager();
        private bool logged=false;

        public void Register(string name, string email, string password)
        {
           
            User newdata=new User(name, email, password);
            user[count] = newdata;
            count++;
        }
        public void Login(string email,string pass) 
        {
            for(int i=0; i<count; i++)
            {
                if (user[i].Email == email && user[i].Password==pass)
                {
                    Console.WriteLine("Login Successfull !!!");
                    Console.WriteLine();
                    logged = true;
                    string? inp = "0";
                    if (logged)
                    {
                        while (inp!="3")
                        {
                            Console.WriteLine("1.post job\n");
                            Console.WriteLine("2.List job\n");
                            Console.WriteLine("3.Back to main menu\n");
                            inp = Console.ReadLine();
                            if (inp == "1")
                            {
                                job.Addjob();
                            }
                            if (inp == "2")
                            {
                                job.ListJob();
                            }
                            if (inp == "3")
                            {
                                Console.WriteLine("Exit");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Option");
                            }

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid User !!!");
                    return;
                }
            }
        }

    }
}
