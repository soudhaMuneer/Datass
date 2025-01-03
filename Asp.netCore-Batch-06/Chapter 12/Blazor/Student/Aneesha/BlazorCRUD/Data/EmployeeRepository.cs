using System.Security.Cryptography;

namespace BlazorCRUD.Data
{
    public class EmployeeRepository
    {
        List<EmployeeDetails> _employeeslist = new List<EmployeeDetails>();

        public void AddEmployee(EmployeeDetails employee)
        {
            employee.Id = _employeeslist.Count + 1;
            _employeeslist.Add(employee);
        }

        public List<EmployeeDetails> GetEmployees()
        {
            return _employeeslist;
        }

        public EmployeeDetails GetEmployeeId(int id)
        {
            return _employeeslist.FirstOrDefault(e => e.Id == id);
        }

        public void UpdateEmployee(EmployeeDetails employee)
        {
            EmployeeDetails employeeDetails = GetEmployeeId(employee.Id);

            if(employeeDetails != null)
            {
                employeeDetails.Id = employee.Id;
                employeeDetails.FirstName = employee.FirstName;
                employeeDetails.LastName = employee.LastName;
                employeeDetails.Email = employee.Email;
                employeeDetails.Phone = employee.Phone;
            }
        }

        public void DeleteEmployee(EmployeeDetails employee) 
        {
            EmployeeDetails employeeDetails = GetEmployeeId(employee.Id);
            if(employeeDetails != null)
            {
                _employeeslist.Remove(employeeDetails);
            }
        }
    }
}
