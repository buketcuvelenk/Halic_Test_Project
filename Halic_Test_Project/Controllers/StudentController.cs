using Halic_Test_Project.Models;
using Halic_Test_Project.StudentData;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Halic_Test_Project.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentData _studentData;

        public StudentController(IStudentData studentData)
        {
            _studentData = studentData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStudents()
        {
            return Ok(_studentData.GetStudents());
        }

        [HttpGet]
        [Route("api/[controller]/{StudentID}")]
        public IActionResult GetStudent(Guid StudentID)
        {
            var student = _studentData.GetStudent(StudentID);
            if (student != null)
            {
                return Ok(student);
            }

            return NotFound($"Student with Student ID was not found");

        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetStudent(Student student)
        {
            _studentData.AddStudent(student);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + student.StudentID, student);

        }

        [HttpDelete]
        [Route("api/[controller]/{StudentID}")]
        public IActionResult DeleteStudent(Guid StudentID)
        {
            var student = _studentData.GetStudent(StudentID);
            if (student != null)
            {
                _studentData.DeleteStudent(student);
                return Ok();
            }

            return NotFound($"Student was delete.");

        }

        [HttpPatch]
        [Route("api/[controller]/{StudentID}")]
        public IActionResult UpdateStudent(Guid StudentID, Student student)
        {
            var existingStudent = _studentData.GetStudent(StudentID);
            if (existingStudent != null)
            {
                student.StudentID = existingStudent.StudentID;
                _studentData.UpdateStudent(student);
               
            }
            return Ok(student);


        }
    }
}
