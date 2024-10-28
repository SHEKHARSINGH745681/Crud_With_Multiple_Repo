using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Moddels.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeAdminPortal.Repository
{
    public class DepImplRepo : DepRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public DepImplRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddDepartment(Department department)
        {
            await _dbContext.Departments.AddAsync(department);
           await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await _dbContext.Departments.ToListAsync();
        }

       
    }

}
