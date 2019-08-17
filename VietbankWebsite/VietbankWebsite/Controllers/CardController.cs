using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VietbankWebsite.Controllers
{
    [Route("the")]
    [Route("card")]
    public class CardController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("san-pham")]
        [Route("product")]
        public IActionResult Product()
        {
            return View();
        }

        [HttpGet]
        [Route("san-pham/{detail}")]
        [Route("product/{detail}")]
        public IActionResult ProductDetail(string detail)
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/bieu-mau")]
        [Route("support/forms")]
        public IActionResult Forms()
        {
            return View();
        }

        [HttpGet]
        [Route("uu-dai/chuong-trinh-khuyen-mai")]
        [Route("incentives/promotions")]
        public IActionResult Promotions()
        {
            return View();
        }

        [HttpGet]
        [Route("uu-dai/happy-day")]
        [Route("incentives/happy-day")]
        public IActionResult HappyDay()
        {
            return View();
        }
    }
}