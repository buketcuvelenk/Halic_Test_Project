using Halic_Test_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Halic_Test_Project.StudentData
{
    public class MockStudentData : IStudentData
    {
        private List<Student> students = new List<Student>()
        {
            new Student()
            {
                StudentID = Guid.NewGuid(),
                Name = "Student Name_One",
                Surname = "Student Surname",
                Class = "Student Class",
                DateOfBirth = null
    },
            
             new Student()
            {
                StudentID = Guid.NewGuid(),
                Name = "Student Name_Two",
                Surname = "Student Surname",
                Class = "Student Class",
                DateOfBirth = null
            }
        };

        public Student AddStudent(Student student)
        {
            student.StudentID = Guid.NewGuid();
            students.Add(student);
            return student;
        }

        public Student DeleteStudent(Student student)
        {
           
            students.Remove(student);
            return student;
           
        } 

        public Student GetStudent(Guid StudentID)
        {
            return students.SingleOrDefault(x=> x.StudentID == StudentID);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public Student UpdateStudent(Student student)
        {
            var existingStudent = GetStudent(student.StudentID);
            existingStudent.Name = student.Name;
            return existingStudent;
        }

    }
}
