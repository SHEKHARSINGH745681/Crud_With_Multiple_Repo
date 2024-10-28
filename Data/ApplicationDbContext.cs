using EmployeeAdminPortal.Moddels.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext

    {
       
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Position> Positions { get; set; }



    }


}
