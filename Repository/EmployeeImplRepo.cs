using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Moddels.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Repository
{
    public class EmployeeImplRepo : EmployeeRepo
    {
        private readonly ApplicationDbContext _dbContext; 
        public EmployeeImplRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _dbContext.Employees.ToListAsync(); 
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _dbContext.Employees.FindAsync(id); 
        }

        public async Task AddEmployee(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee); 
            await _dbContext.SaveChangesAsync(); 
        }

        public async Task UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee); 
            await _dbContext.SaveChangesAsync(); 
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id); 
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee); 
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}

