namespace BlazorCRUD.Data
{
    public class EmployeeService
    {
        EmployeeRepository _repository;
        public EmployeeService(EmployeeRepository repository)
        {
            this._repository = repository;
        }

        public void AddEmployeeList(EmployeeDetails employee)
        {
            _repository.AddEmployee(employee);  
        }

        public List<EmployeeDetails> GetEmployeeList()
        {
            return _repository.GetEmployees();
        }

        public EmployeeDetails GetEmployeeListById(int id)
        {
            return _repository.GetEmployeeId(id);
        }

        public void UpdateEmployeeList(EmployeeDetails employee)
        {
            _repository.UpdateEmployee(employee);
        }

        public void DeleteEmployeeList(EmployeeDetails employee)
        {
            _repository.DeleteEmployee(employee);
        }

    }
}
