using Halic_Test_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Halic_Test_Project.StudentData
{
    public class SqlStudentData : IStudentData
    {
        private StudentContext _studentContext;
        public SqlStudentData(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public Student AddStudent(Student student)
        {
            student.StudentID = Guid.NewGuid();
            _studentContext.Students.Add(student);
            _studentContext.SaveChanges();
            return student;
        }

        public Student DeleteStudent(Student student)
        {
            _studentContext.Students.Remove(student);
            _studentContext.SaveChanges();
            return student;
        }
        
        public Student GetStudent(Guid StudentID)
        {
            var student = _studentContext.Students.Find(StudentID);
            return student; 
        }

        public List<Student> GetStudents()
        {
           return _studentContext.Students.ToList();
        } 

        public Student UpdateStudent(Student student)
        {
            var existingStudent = _studentContext.Students.Find(student.StudentID);
            if(existingStudent != null)
            {
                existingStudent.Name = student.Name;
                _studentContext.Students.Update(existingStudent);
                _studentContext.SaveChanges();
            }

            return student;
            
        }
    }
}
