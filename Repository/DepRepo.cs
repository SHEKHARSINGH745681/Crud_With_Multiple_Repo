using EmployeeAdminPortal.Moddels.Entities;

namespace EmployeeAdminPortal.Repository
{
    public interface DepRepo
    {
        Task<IEnumerable<Department>> GetAllDepartments();
        Task AddDepartment(Department department);

        // Task<Department> GetDepartmentById(int id);
        //Task UpadetDepartment(Department department);
        //Task DeleteDepartment(int id);
    }
}
