using EmployeeAdminPortal.Moddels.Entities;

namespace EmployeeAdminPortal.Repository
{
    public interface EmployeeRepo
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
       

    }
}
