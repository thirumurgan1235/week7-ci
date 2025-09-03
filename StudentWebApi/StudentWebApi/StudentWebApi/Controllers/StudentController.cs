using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Models;
using StudentWebApi.Models.StudentWebApi.Models;

namespace StudentWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Rooln = 1, Name = "thiru", Batch = "CSE", Marks = 40 },
            new Student { Rooln = 2, Name = "Murugan", Batch = "Ece", Marks = 95 },
            new Student { Rooln = 3, Name = "ganesh", Batch = "ECE", Marks = 78 }
        };

        [HttpGet]
        public IActionResult GetAll() => Ok(students);

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Rooln == id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Student updated)
        {
            var student = students.FirstOrDefault(s => s.Rooln == id);
            if (student == null) return NotFound();

            student.Name = updated.Name;
            student.Batch = updated.Batch;
            student.Marks = updated.Marks;

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Rooln == id);
            if (student == null) return NotFound();

            students.Remove(student);
            return Ok();
        }
    }
}
