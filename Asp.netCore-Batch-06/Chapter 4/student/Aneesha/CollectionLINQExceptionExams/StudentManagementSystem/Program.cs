using StudentManagementSystem.Manager;
using StudentManagementSystem.Model;

namespace StudentManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentCollection manager = new StudentCollection();
           
            while (true)
            {
                Console.WriteLine("Welcome to student management system..");
                Console.WriteLine();
                
                Console.WriteLine("1.List all Students");
                Console.WriteLine("2.Add student");
                Console.WriteLine("3.Remove Student");
                Console.WriteLine("4.Get student by id ");

                Console.Write("choose task you want to perform : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        manager.ListAllStudent();
                        break;
                    case 2:
                        manager.AddStudent();
                        break;
                    case 3:
                        Console.Write("Enter id you want to remove : ");
                        int studentID = Convert.ToInt32(Console.ReadLine());
                        manager.RemoveStudent(studentID);
                        break;
                    case 4:
                        Console.Write("Enter id you want to get : ");
                        int students = Convert.ToInt32(Console.ReadLine());
                        manager.GetStudent(students);
                        break;


                }
            }
        }
    }
}