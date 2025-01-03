using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Program
    {
        struct Members
        {
            public string name;
            public string email;
            public string designation;
            public int number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hire Me Now Job Portal! ");
                Console.WriteLine("1.Login");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        login();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
               
        }
            static void login()
            {
            string ch;
            Members[] members = new Members[10]; 
            Console.WriteLine("Please enter your email:");
            string email= Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
            Console.WriteLine("Login Successful");
            do
            {
                Console.WriteLine("1.Add Company Members");
                Console.WriteLine("2.List Company Members");
                Console.WriteLine("3.Logout");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("How many members you want to add?");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Please enter company member name {0}:",i+1);
                            members[i].name = Console.ReadLine();
                            Console.WriteLine("Please enter company member email {0}:",i+1);
                            members[i].email = Console.ReadLine();
                            Console.WriteLine("Please enter company member designation {0}:",i+1);
                            members[i].designation = Console.ReadLine();
                            Console.WriteLine("Please enter company member phone number {0}:",i+1);
                            members[i].number = Convert.ToInt32(Console.ReadLine());

                        }
                        break;



                    case 2:

                        Console.WriteLine("Members List");
                        for (int i = 0; i < members.Length; i++)
                        {
                            if (members[i].name != null)
                            {
                                Console.WriteLine("----------------------------------------------------------------");
                                Console.WriteLine("company member name: {0}", members[i].name);
                                Console.WriteLine("company member email :{0}", members[i].email);
                                Console.WriteLine("company member designation: {0}", members[i].designation);
                                Console.WriteLine("company member phone number: {0}", members[i].number);
                            }
                        }
                        break;


                    case 3:
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue yes/no");
                ch = Console.ReadLine();
            } while (ch == "y" || ch == "Y");
            }

        
    }
}
