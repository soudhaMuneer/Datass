using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
	public class StudentCollection :IStudentCollection
	{
		private List<Student> students;

		public StudentCollection()
		{
			students = new List<Student>();
		}

		public void AddStudent(Student student)
		{
			students.Add(student);
		}

		public void RemoveStudent(string studentID)
		{
			Student studentToRemove = students.Find(s => s.StudentID == studentID);
			if (studentToRemove != null)
			{
				students.Remove(studentToRemove);
				Console.WriteLine("Student removed successfully.");
			}
			else
			{
				Console.WriteLine("Student not found.");
			}
		}

		public Student GetStudent(string studentID)
		{
			return students.Find(s => s.StudentID == studentID);
		}

		public void ListAllStudents()
		{
			Console.WriteLine("List of Students:");
			foreach (var student in students)
			{
				Console.WriteLine($"ID: {student.StudentID}, Name: {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
			}
		}
	}
}
