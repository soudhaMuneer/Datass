using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using StudentManagementSystem.Interface;
using StudentManagementSystem.Model;

namespace StudentManagementSystem.Manager
{
    public class StudentCollection:IStudentCollection
    {
        
        public List<Student> Students = new List<Student>
        {
            new Student { StudentID = 1,Name = "Haneesha",Age = 24,GPA = 8.12 },
            new Student { StudentID = 2 ,Name = "John" ,Age = 34,GPA = 9.23},
            new Student { StudentID = 3 ,Name = "smith" ,Age = 44,GPA = 9.23}

        };
        public void AddStudent()
        {
            Console.Write("Enter Id : ");
            int StudentID = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Enter GPA : ");
            double GPA = double.Parse(Console.ReadLine());

            Student newStudent = new Student
            {
                StudentID = StudentID,
                Name = Name,
                Age = Age,
                GPA = GPA
            };
            Students.Add(newStudent);

            Console.WriteLine("Student Details Added successfull");
        }


        public void RemoveStudent(int studentID)
        {
            var removeItem = Students.FirstOrDefault(s => s.StudentID == studentID);
            if (removeItem != null)
            {
                Students.Remove(removeItem);
            }
        }
        public List<Student> GetStudent(int studentID)
        {
            var student = Students.FirstOrDefault(s => s.StudentID == studentID);

            if (student != null)
            {
                Console.WriteLine($"Student ID: {student.StudentID}");
                Console.WriteLine($"Student Name: {student.Name}");
                Console.WriteLine($"Student Age: {student.Age}");
                Console.WriteLine($"Student GPA: {student.GPA}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            return Students;
        }
        public List<Student> ListAllStudent()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"student id : {student.StudentID}");
                Console.WriteLine($"student name : {student.Name}");
                Console.WriteLine($"student age : {student.Age}");
                Console.WriteLine($"student gpa : {student.GPA}");
                Console.WriteLine("************************************");

            }
            
            return Students;

            
        }
    }
}
