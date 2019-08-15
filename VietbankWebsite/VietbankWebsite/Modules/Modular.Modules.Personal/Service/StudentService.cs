using Modular.Modules.Personal.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Vietbank.Core.Models;

namespace Modular.Modules.Personal.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetStudents()
        {
            return _studentRepository.GetStudents();
        }
    }

    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
