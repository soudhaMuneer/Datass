using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
namespace PostMember
{
    internal class Program
    {
        struct CompanyMember
        {
            public int Userid;
            public string Designation;
            public string Name;
            public string email;
            public long phone;
     

        }
        struct jobprovider
        {
            public string Email;
            public string Password;
        }






        static jobprovider[] jprovider = new jobprovider[1] {new jobprovider {Email="rinshad@gmail.com",Password="123"} };
        static jobprovider loggedinUser;
        static bool loggedoutUser=false;
        public static void Main(string[] args)
        {
            CompanyMember[] members = new CompanyMember[1];



            string choice;
            
                Console.WriteLine("welcome to hire me now job portel");
            Console.WriteLine();
                Console.WriteLine("1.login");
                string command1= Console.ReadLine();
            switch (command1)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("please enter your Email:");
                    string email = Console.ReadLine();

                    Console.WriteLine("please enter your Password:");
                    string password = Console.ReadLine();
                    Console.WriteLine();

                   

                    bool loginSuccessfull = false;

                    foreach (jobprovider jp in jprovider) { 
                        
                        if (jp.Email == email && jp.Password == password) {
                            loginSuccessfull = true;
                            loggedoutUser = true;
                            loggedinUser = jp;

                            Console.WriteLine("Login Successfull");
                        }
                    
                        else
                        {
                            Console.WriteLine("invalid password/invalid email, try again");
                            return;
                        }
                    }
                   break
                        ;
                
                        
            }
            
        

            do
            {
                Console.WriteLine();
                Console.WriteLine("1.list all company members");
                Console.WriteLine("2.Add company members");
                Console.WriteLine("3.logout");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        
                            for (int i = 0; i < 1; i++)
                            {





                                Console.WriteLine();
                                    Console.WriteLine("user id{0}", members[i].Userid);

                                    Console.WriteLine("designation {0}", members[i].Designation);
                                    Console.WriteLine("name {0}", members[i].Name);
                                    Console.WriteLine("email {0}", members[i].email);
                                    Console.WriteLine("phone {0}", members[i].phone);
                                }

                            
                            Console.WriteLine();
                            break;
                        


                    case "2":
                        
                            for (int i = 0; i < 1; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine("please enter the company member name");
                                members[i].Name = Console.ReadLine();
                                Console.WriteLine("please enter the company member email");
                                members[i].email = Console.ReadLine();
                                Console.WriteLine("please enter the company member designation");
                                members[i].Designation = Console.ReadLine();
                                Console.WriteLine("please enter the company member phone number");
                                members[i].phone = Convert.ToInt64(Console.ReadLine());


                            }
                            Console.WriteLine("registration succesfull");
                            break;

                    case "3":
                        {
                            loggedoutUser = false;
                            Console.WriteLine("Logged out successfully");
                        }


                        break;
                        
                  

                    

                       
                }
                Console.WriteLine("Do you want to continue (yes/No)\n");
                choice = Console.ReadLine();



            }
            while (choice == "yes");


        }
    }
}