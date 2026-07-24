using Microsoft.AspNetCore.Mvc;
using Lab2_StudentAPI.Models;

namespace Lab2_StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new()
        {
            new Student
            {
                Id = 1,
                Name = "Monika",
                Age = 20,
                Branch = "CSE"
            },
            new Student
            {
                Id = 2,
                Name = "Rahul",
                Age = 21,
                Branch = "ECE"
            }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            students.Add(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Branch = updatedStudent.Branch;

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            students.Remove(student);

            return Ok("Student deleted successfully");
        }
    }
}