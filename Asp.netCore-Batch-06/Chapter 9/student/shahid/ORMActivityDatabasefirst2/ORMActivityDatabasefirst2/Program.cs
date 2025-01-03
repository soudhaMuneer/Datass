using ORMActivityDatabasefirst2.Models;
using System;
namespace Myapp
{
    public class Program
    {
        static int studentid = 1 , Gradeid=1;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice \n 1.Add Student and Grade \n 2.List Student Grade");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Student student = new Student();
                        Grade grade = new Grade();
                       
                        Console.WriteLine("Enter First name ");
                        student.Firstname = Console.ReadLine();
                        Console.WriteLine("Enter Last name ");
                        student.Lastname = Console.ReadLine();
                        Console.WriteLine("Enter Grade");
                        grade.Gradename = Console.ReadLine();
                        Addstudent(student,grade);
                        break;
                        case "2":
                        ListStudent();
                        break;
                }
            }
        }
        public static void Addstudent(Student student,Grade grade)
        {
            SchoolDb2Context db = new SchoolDb2Context();
            student.Studentid = studentid;
            
            grade.Gradeid = Gradeid;
            db.Grades.Add(grade);

            db.Students.Add(student);
            db.SaveChanges();

            studentid++;
            Gradeid++;
        }
        public static void ListStudent()
        {
            SchoolDb2Context schoolDb2Context = new SchoolDb2Context();
            var studentlist = schoolDb2Context.Students.ToList();
            foreach (var st in studentlist)
            {
                Console.WriteLine(st.Studentid);
                Console.WriteLine(st.Firstname);
                Console.WriteLine(st.Lastname);
                Console.WriteLine(st.Gradeid);
                Console.WriteLine(st.Grade);
            }
        }
    }
}