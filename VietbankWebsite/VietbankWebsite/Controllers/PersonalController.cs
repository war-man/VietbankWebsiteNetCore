using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VietbankWebsite.Controllers
{
    [Route("ca-nhan")]
    [Route("personal")]
    public class PersonalController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("ban-can")]
        [Route("you-need")]
        public IActionResult YouNeed()
        {
            return View();
        }

        [Route("ban-can/{youneed}")]
        [Route("you-need/{youneed}")]
        public IActionResult YouNeedDetail(string youneed)
        {
            return View();
        }
    }
}