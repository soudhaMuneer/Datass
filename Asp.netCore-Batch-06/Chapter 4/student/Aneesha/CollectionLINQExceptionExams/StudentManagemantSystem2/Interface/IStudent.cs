using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagemantSystem2.Interface
{
    public interface IStudent
    {
        void AddStudent(string name, int age,string grade);
        void RemoveStudent(string name);
        void DisplayStudents();
    }
}
