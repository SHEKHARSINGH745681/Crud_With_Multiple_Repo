using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Moddels.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Repository
{
    public class EmployeeImplRepo : EmployeeRepo

    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeImplRepo(ApplicationDbContext dbContext)
        {
            dbContext = dbContext; // Initialize the dbContext
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }
    }
}
