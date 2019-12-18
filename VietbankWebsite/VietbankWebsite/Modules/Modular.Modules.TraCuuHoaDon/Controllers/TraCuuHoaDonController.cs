using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modular.Modules.TraCuuHoaDon.Controllers
{
    [Route("tracuuhoadon")]
    public class TraCuuHoaDonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
