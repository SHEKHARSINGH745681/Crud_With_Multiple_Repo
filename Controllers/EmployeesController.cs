using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Moddels;
using EmployeeAdminPortal.Moddels.Entities;
using EmployeeAdminPortal.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    //localhost:7028/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeRepo employeeRepo;
        private readonly DepRepo depRepo;
        private readonly PositionRepo positionRepo;
        public EmployeesController(EmployeeRepo employeeRepo, DepRepo depRepo, PositionRepo positionRepo)
        {
            this.employeeRepo = employeeRepo;
            this.depRepo = depRepo;
            this.positionRepo = positionRepo;
        }




        [HttpGet]

        public async Task<IActionResult> GetAllEmployees()
        {
            IEnumerable<Employee> employees = await employeeRepo.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await employeeRepo.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            await employeeRepo.AddEmployee(employee);
            return Ok(new { message = "Employee created successfully." });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            var existingEmployee = await employeeRepo.GetEmployeeById(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            await employeeRepo.UpdateEmployee(employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await employeeRepo.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            await employeeRepo.DeleteEmployee(id);
            return NoContent();
        }


        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllDepartments()
        {
            IEnumerable<Department> departments = await depRepo.GetAllDepartments();
            return Ok(departments);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddDepartment(Department department)
        {
            if (department == null)
            {
                return BadRequest();
            }

            await depRepo.AddDepartment(department);
            return Ok(new { message = "Department created successfully." });
        }
        [HttpGet]
        [Route("allposition")]
        public async Task<IActionResult> GetAllPosition()
        {
            IEnumerable<Position> positions = await positionRepo.GetAllPosition();
            return Ok(positions);
        }

        [HttpPost]
        [Route("addposition")]
        public async Task<IActionResult> AddPosition(Position position)
        {
            if (position == null)
            {
                return BadRequest();
            }

            await positionRepo.AddPosition(position);
            return Ok(new { message = "Position created successfully." });
        }
    }
}





