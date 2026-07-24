using Microsoft.AspNetCore.Mvc;
using Lab3_EmployeeAPI.Models;

namespace Lab3_EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Department = "HR",
                Salary = 30000
            },
            new Employee
            {
                Id = 2,
                Name = "Monika",
                Department = "IT",
                Salary = 50000
            }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found");

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee updatedEmployee)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found");

            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            employee.Salary = updatedEmployee.Salary;

            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found");

            employees.Remove(employee);

            return Ok("Employee deleted successfully");
        }
    }
}