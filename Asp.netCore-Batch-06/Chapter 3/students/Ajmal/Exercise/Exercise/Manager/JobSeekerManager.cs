using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Manager
{
    public class JobSeekerManager 
    {
        public static JobSeeker[] Seekers = new JobSeeker[10];
        public JobManager JobManager=new JobManager();
        public int count = 0;
        private bool logged = false;
        JobSeeker JobSeeker = new JobSeeker();
        

        public void Register(string FirstName, string ln, string mail, string phone, string location, string aboutme, string Qualification, string pass)
        {
          
            JobSeeker seeker = new JobSeeker(FirstName, ln, mail, phone, location, aboutme, Qualification, pass);
            Seekers[count]= seeker;
            count++;
          
        }
       

        public void LoggedIn(string email,string pass)
        {
            for (int i = 0; i < count; i++)
            {
                if (Seekers[i].Email == email && Seekers[i].password == pass)
                {
                    Console.WriteLine("Login Successfull !!!");
                    Console.WriteLine();
                    logged = true;
                    string? inp = "0";
                    if (logged)
                    {
                        ShowMainmenu();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid User !!!");
                    return;
                }
            }

            
        }

        public void ShowMainmenu()
        {
            string? inp = "0";
            while (inp != "4")
            {
                Console.WriteLine("1.Show JobSeekerMenu\n");
                Console.WriteLine("2.Show JobProviderMenu\n");
                Console.WriteLine("3.Platform Admin\n");
                Console.WriteLine("4.Logout\n");
                Console.WriteLine();
                Console.WriteLine("Choose any");
                inp = Console.ReadLine();
                switch (inp)
                {
                    case "1":
                        JobManager.ShowJobseekermenu();
                        break;
                    case "2":
                        Console.WriteLine("Coming soon !!!");
                        break;
                    case "3":
                        Console.WriteLine("Coming soon !!!");
                        break;
                    case "4":
                        Console.WriteLine("Exitted");
                        break;
                  
                    
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }


            }
        
    }

        public void Profile()
        {
            for(int i = 0;i<count;i++)
            {
                Console.WriteLine("FirstName :- {0 ,-30} LastName :- {1,-30}\nPlace :- {2,-30} About Me :- {3,-40}\nExperience Level :- {4,-30} Qualification :- {5,-40}", Seekers[i].FirstName, Seekers[i].LastName, Seekers[i].Location, Seekers[i].AboutMe, Seekers[i].ExperienceLevel, Seekers[i].Qualification);

            }
        }
    }
}
