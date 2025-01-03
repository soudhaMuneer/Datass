using Microsoft.Identity.Client;
using StudentEF.Model;

namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        int ch;
          StudentContext context;
        List<Studentlist> studentlist = new List<Studentlist>();
        do
        {
            Console.WriteLine("Enter choice");
            ch = Convert.ToInt32(Console.ReadLine());
            Studentlist st = new Studentlist();
            switch (ch)
            {

                case 1:
                    Console.WriteLine("Enter Name");
                    st.Name = Console.ReadLine();
                    Console.WriteLine("Enter Grade");
                    st.Grade = Guid.Parse(Console.ReadLine());
                    AddStudent(st);
                    break;
                case 2:
                    ListStudent(); 
                   
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

        } while (ch != 3);
    }
    public static void AddStudent(Studentlist studentlist)
    {
       StudentContext studentContext = new StudentContext();
studentContext.Studentlists.Add(studentlist);
        studentContext.SaveChanges();
    }
    public static void ListStudent()
    {
        StudentContext studentContext = new StudentContext();
        var list=studentContext.Studentlists.ToList();
       foreach( var student in list ) {
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Grade);
        }

    }
}