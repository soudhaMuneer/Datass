namespace EmployeeCrud.Data
{
    public class EmployeeService
    {
        private List<Employee> _employees= new List<Employee> { new Employee(1,"arjun","anu","rag","680519","attoor","arjun@gamil.com") };
        public EmployeeService()
        {
            
        }
        public List<Employee> GetEmployees()
        {
            return _employees;
        }
        public Employee GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(i => i.Id == id);
        }
        public bool AddEmployee(Employee employee)
        {
            employee.Id = _employees.Any() ? _employees.Max(i => i.Id) + 1 : 1;
            _employees.Add(employee);
            return true;
        }
        public void UpdateEmployee(Employee employee)
        {
            var existingItem = GetEmployeeById(employee.Id);
            if (existingItem != null)
            {
                existingItem.FirstName = employee.FirstName;
                existingItem.LastName = employee.LastName;
                existingItem.MiddleName = employee.MiddleName;
                existingItem.PostalCode = employee.PostalCode;
                existingItem.Address = employee.Address;
                existingItem.EmailAddress = employee.EmailAddress;
            }
        }
        public void DeleteEmployeeService(int id)
        {
            var item = GetEmployeeById(id);
            if (item != null)
            {
                _employees.Remove(item);
            }
        }
    }
}
