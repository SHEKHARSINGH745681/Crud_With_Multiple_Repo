using EmployeeAdminPortal.Moddels.Entities;

namespace EmployeeAdminPortal.Repository
{
    public interface PositionRepo
    {
        Task<IEnumerable<Position>> GetAllPosition();
        
        Task AddPosition(Position position);
    }
}
