using Database_connection.Models;
using System;

namespace MyApp
{
    public class Program
    {
       public static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Choose options");
                Console.WriteLine("1.Add Students");
                Console.WriteLine("2.List Students");
                num = Convert.ToInt32(Console.ReadLine());
                
                switch (num)
                {
                    case 1:
                        addStudent();
                        break;
                    case 2:
                        Liststudents();
                        break;

                        default:
                        Console.WriteLine("invalid bumber");
                        break;
                }
            } while (num != 3);
        }
        public static void addStudent()
        {
            Console.WriteLine("Count------");
            Student student = new Student();
            Grade grade = new Grade();
            
            OrmdataContext context = new OrmdataContext();
            student.StudentId = context.Students.Count()+1;
            Console.WriteLine("Student Name : ");
            student.Name = Console.ReadLine();
            Console.WriteLine("grade : ");
            grade.Grade1 = Console.ReadLine();
            Grade grade1= context.Grades.FirstOrDefault(x => x.Grade1==grade.Grade1);
            if (grade1!=null) 
            {
                student.GradeId = grade1.GradeId;
            }
            else
            {
                grade.GradeId = context.Grades.Count() + 1;
                student.GradeId = grade.GradeId;
            }
           
            
            
            context.Grades.Add(grade);
            context.Students.Add(student);

           
            context.SaveChanges();   
        }
        public static void Liststudents() 
        {
            OrmdataContext ctx = new OrmdataContext();
            var datas= ctx.Students.ToList();
            foreach (var data in datas)
            {
                Console.WriteLine(data.StudentId);
                Console.WriteLine(data.Name);
                Console.WriteLine(data.GradeId);
            }
            
            Console.WriteLine("1.Update Students");
            Console.WriteLine("2.Delete Student");
            int inp2 = Convert.ToInt32(Console.ReadLine());
            switch (inp2)
            {
                case 1:
                    UpdateData();

                    break;
                case 2:
                    deleting();
                    break;
            }
            void UpdateData()
            {
                Console.WriteLine("Update Data with id : ");
                int inp = Convert.ToInt32(Console.ReadLine());
                var student = ctx.Students.Find(inp);
                if (student != null)
                {
                    Console.WriteLine("Update Student Details");
                    Console.WriteLine("Student Name");
                    student.Name = Console.ReadLine();
                    ctx.SaveChanges();
                    Liststudents();
                }
                else
                {
                    Console.WriteLine("No Student found!");
                }
            }
            void deleting()
            {
                Console.WriteLine("Delete Data with id : ");
                int inp = Convert.ToInt32(Console.ReadLine());
                var student = ctx.Students.Find(inp);
                if (student != null)
                {
                    ctx.Students.Remove(student);
                    ctx.SaveChanges();
                    Liststudents();
                }
                else
                {
                    Console.WriteLine("No Student found!");
                }
            }
        }
        
    }
}