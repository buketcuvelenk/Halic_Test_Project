using Halic_Test_Project.Models;
using System;
using System.Collections.Generic;


namespace Halic_Test_Project.StudentData
{
    public interface IStudentData
    {
        List<Student> GetStudents();

        Student GetStudent(Guid StudentID);
        Student AddStudent(Student student);
        Student DeleteStudent(Student student);
        Student UpdateStudent(Student student);

    }
}
