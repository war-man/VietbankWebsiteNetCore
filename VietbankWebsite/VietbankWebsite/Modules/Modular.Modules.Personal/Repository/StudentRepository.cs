using System;
using System.Collections.Generic;
using System.Text;
using Vietbank.Core.Models;

namespace Modular.Modules.Personal.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            students.Add(new Student()
            {
                Id = 1,
                Name = "Le Anh Toan",
                Age = 30
            });

            return students;
        }
    }

    public interface IStudentRepository
    {
        List<Student> GetStudents(); 
    }
}
