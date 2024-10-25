using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Moddels;
using EmployeeAdminPortal.Moddels.Entities;
using EmployeeAdminPortal.Models.Entities;
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
        public EmployeesController(EmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        //[HttpGet]
        //public IActionResult GetAllEmployees()
        //{
        //    return Ok(dbContext.Employees.ToList());
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            IEnumerable<Employee> employees = await employeeRepo.GetAllEmployees();
            return Ok(employees);
        }






        //[HttpGet("{id}")]
        //public IActionResult GetEmployeeById(int id)
        //{
        //    var employee = dbContext.Employees.Find(id);

        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(employee);
        //}



        ////find by List (employee and department)
        //[HttpGet("list")] 
        //public IActionResult GetEmployeeListById()
        //{
        //    var employeeList = dbContext.Employees
        //        .Include(e => e.Department) 
        //        .ToList();


        //    return Ok(employeeList);
        //}

        //[HttpGet("list/{id}")]
        //public IActionResult GetEmployeesById(int id)
        //{
        //    var employee = dbContext.Employees
        //        .Include(e => e.Department)
        //        .FirstOrDefault(e => e.Id == id);

        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(employee);
        //}

        ////employee

        //[HttpPost]
        //public IActionResult AddEmployee(Employee employee)
        //{

        //    var employeeEntity = new Employee()
        //    {
        //        Name = employee.Name,
        //        Email = employee.Email,
        //        Phone = employee.Phone,
        //        Salary = employee.Salary,
        //        Dep_Id = employee.Dep_Id,
        //    };

        //    dbContext.Employees.Add(employeeEntity);
        //    dbContext.SaveChanges();

        //    return Ok(employeeEntity);
        //}

        ////Department
        //[HttpPost]
        //[Route("department")]
        //public IActionResult AddDepartment(Department department)
        //{
            
        //    var departmentEntity = new Models.Entities.Department() 
        //    {
        //        Address = department.Address,
        //        BloodGroup = department.BloodGroup,
        //        Position = department.Position,
        //        Experience = department.Experience,
        //    };

        //    // Add the new entity to the DbContext
        //    dbContext.Departments.Add(departmentEntity);

        //    // Save changes to the database
        //    dbContext.SaveChanges();

        //    // Return the created department entity as a response
        //    return Ok(new
        //    {
        //        Message = "Department created successfully!",
        //        Department = departmentEntity
        //    });
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateEmployee(int id, Employee employee)
        //{
        //    var employees = dbContext.Employees.Find(id);

        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }
        //    employee.Name = employee.Name;
        //    employee.Email = employee.Email;
        //    employee.Phone = employee.Phone;
        //    employee.Salary = employee.Salary;

        //    dbContext.SaveChanges();

        //    return Ok(employee);


        //}

        //[HttpDelete]
        //public IActionResult DeleteEmployee(int id)
        //{
        //    var employee = dbContext.Employees.Find(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }
        //    dbContext.Employees.Remove(employee);
        //    dbContext.SaveChanges();

        //    return Ok(employee);
        //}
    }
}
