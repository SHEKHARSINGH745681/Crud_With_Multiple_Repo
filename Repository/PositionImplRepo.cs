using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Moddels.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeAdminPortal.Repository
{
    public class PositionImplRepo : PositionRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public PositionImplRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddPosition(Position position)
        {
            await _dbContext.Positions.AddAsync(position);
            await _dbContext.SaveChangesAsync();
        }

        public  async Task<IEnumerable<Position>> GetAllPosition()
        {
            return await _dbContext.Positions.ToListAsync();
        }
    }
}
