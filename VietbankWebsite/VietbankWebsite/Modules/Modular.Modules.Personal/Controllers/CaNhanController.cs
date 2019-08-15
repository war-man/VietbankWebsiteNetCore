using Microsoft.AspNetCore.Mvc;
using Modular.Modules.Personal.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modular.Modules.Personal.Controllers
{
    public class CaNhanController : Controller
    {
        private readonly IStudentService _studentService;
        public CaNhanController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {

            ViewBag.Greeting = _studentService.GetStudents().Count;
            return View();
        }
    }
}
