using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Interface
{
    public interface IStudentCollection
    {
        void AddStudent();
        void RemoveStudent(int studentID);
        List<Student> GetStudent(int studentID);
        List<Student> ListAllStudent();
    }
}
