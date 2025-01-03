using PetsExcercise.Enums;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static MyApp.PetsExcercise;

namespace MyApp
{
    public class PetsExcercise
    {
        public struct User
        {
            public int id;
            public string name;
            public string email;
            public string password;
            public string phone;
            public string address;
            public string city;
            public string state;
            public Role role;
        }
        public struct Pet
        {
            public int id;
            public string petName;
            public PetCategory petCategory;
            public int userId;
            
        }
        static User[] users = new User[10];
        static Pet[] pets = new Pet[10];
        static int count = 0;
        public static bool isLogged=false;
        public static User loggedUser;
        public static int totalpetCount=0;
        static void Main(string[] args)
        { int choice;
            
            
            do
            {
                Console.WriteLine("Choose any Option \n 1.Register\n2.Login \n3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:Console.WriteLine("Enter the user Details");
                        RegisterUser();
                        break;
                        case 2:
                        UserLogin();
                        if(loggedUser.role==Role.PublicUser)
                        {
                            ShowUserMenu();
                        }
                        break;
                }
            } while (choice != 3);

            

        }

        public static void RegisterUser()
        {
            Console.WriteLine("Howmany Number of Users You want to Add");
            int userCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userCount; i++)
            {
                User ob = new User();
                ob.id = userCount;
                Console.WriteLine("Enter Name of User");
                ob.name = Console.ReadLine();
                Console.WriteLine("Enter email of User");
                ob.email = Console.ReadLine();
                Console.WriteLine("Enter Phone Number of User");
                ob.phone = Console.ReadLine();
                Console.WriteLine("Enter the City Name");
                ob.city = Console.ReadLine();
                Console.WriteLine("Enter the State");
                ob.state = Console.ReadLine();
                ob.role = Role.PublicUser;
                Console.WriteLine("Enter Address Number of User");
                ob.address = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ob.password = Console.ReadLine();
                users[count] = ob;
                count++;
            }
        }
        public static void ShowUserMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Post Pet \n 2.List Pet \n 3.Logout\n 4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: Console.WriteLine("-----------Post a Pet--------------");
                        PostPet();break;
                    case 2:
                        Console.WriteLine("-----------list Pets--------------");
                        ListPets(); break;
                    case 3:Logout();

                        break;
                    default:break;


                }
                
            } while (choice != 4);
        }
        public static void Logout()
        {
            loggedUser = new User();
        }
        public static void PostPet()
        {
            Console.WriteLine("Enter the number of pets you want to post");
            int petCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < petCount;i++)
            {
                Pet newPet= new Pet();  
                Console.WriteLine("Details of {0}th Pet", i + 1);
                newPet.id = totalpetCount + 1;
                Console.WriteLine("Name:");
                newPet.petName = Console.ReadLine(); int choice;
                bool chance = true;
                do
                {
                    Console.WriteLine("Choose a number Corresponding to Category from this  \n1.Dog\n2.Cat\n3.Bird\n4.Fish\n5.Reptile\n6.Other");
                    choice = Convert.ToInt32(Console.ReadLine());
                    chance = true;
                    switch (choice)
                    {
                        case 1: newPet.petCategory = PetCategory.Dog; break;
                        case 2: newPet.petCategory = PetCategory.Cat; break;
                        case 3: newPet.petCategory = PetCategory.Bird; break;
                        case 4: newPet.petCategory = PetCategory.Fish; break;
                        case 5: newPet.petCategory = PetCategory.Reptile; break;
                        case 6: newPet.petCategory = PetCategory.Other; break;
                        default: Console.WriteLine("Invalid Choice please renter the choice"); chance = false; break;
                    }

                } while (chance == false);
                newPet.userId = loggedUser.id;
                pets[totalpetCount] = newPet;    
                totalpetCount++;



            }
        }
        public static void ListPets()
        {
            Console.WriteLine("Pets Details are");
            for(int i=0;i<pets.Length;i++)
            {
                if (pets[i].petName!=null) 
                {
                    var name = UserNamefromId(pets[i].userId);
                    Console.WriteLine("\nName:{0}\n Category:{1}\nUser Name:{2}", pets[i].petName, pets[i].petCategory, name);
                }
                



                
            }
        }
          public static void UserLogin()
            
        {
            Console.WriteLine("Enter Email");
            string email=Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password=Console.ReadLine(); 
            for(int i=0;i<count;i++)
            {
                if (users[i].email !=null)
                {
                    if (users[i].email == email && users[i].password == password)
                    {
                        Console.WriteLine("Login successfull");
                        loggedUser= users[i];   
                        isLogged=true;
                    }

                }
          
            }
            if(isLogged==false) {
                Console.WriteLine("Ivalid Credentials,No Such user is found");
            }
            }
        public static string UserNamefromId(int userId)
        {   
            string name=null;
            for(int i=0;i<users.Length;i++)
            {
                if (users[i].id == userId)
                {
                    name=users[i].name;
                    break;
                   
                }
                else
                {
                    name = null;
                }
            }
            return name;    
        }

    }
    }
