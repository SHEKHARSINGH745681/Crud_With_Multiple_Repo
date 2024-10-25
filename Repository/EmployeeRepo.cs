using EmployeeAdminPortal.Moddels.Entities;
using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Repository
{
    public interface EmployeeRepo
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
    //    Task<Employee> GetEmployeeById(int id);
    //    Task AddEmployee(Employee employee);
    //    Task UpdateEmployee(Employee employee);
    //    Task DeleteEmployee(int id);

    //    //departments
    //    Task<IEnumerable<Employee>> GetEmployeeListWithDepartmentAsync();

    //    Task<Employee> AddDepartment(Department department);
    }
}
