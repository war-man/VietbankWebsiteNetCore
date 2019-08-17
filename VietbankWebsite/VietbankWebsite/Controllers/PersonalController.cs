using Microsoft.AspNetCore.Mvc;

namespace VietbankWebsite.Controllers
{
    [Route("ca-nhan")]
    [Route("personal")]
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("ban-can")]
        [Route("you-need")]
        public IActionResult YouNeed()
        {
            return View();
        }

        [HttpGet]
        [Route("ban-can/{youneed}")]
        [Route("you-need/{youneed}")]
        public IActionResult YouNeedDetail(string youneed)
        {
            return View();
        }

        [HttpGet]
        [Route("cau-hoi-thuong-gap")]
        [Route("faqs")]
        public IActionResult Faqs()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tien-ich/ty-gia")]
        [Route("support/utility/foreign-exchange")]
        public IActionResult Exchange()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tien-ich/lai-suat")]
        [Route("support/utility/interest-rate")]
        public IActionResult Interest()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tien-ich/lai-suat-co-so")]
        [Route("support/utility/interest-rate-basic")]
        public IActionResult InterestBasic()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tien-ich/bieu-mau")]
        [Route("support/utility/forms-tariff")]
        public IActionResult FormTariff()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tien-ich/bieu-phi")]
        [Route("support/utility/tariff")]
        public IActionResult Tariff()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tien-ich/cong-cu-tinh-toan")]
        [Route("support/utility/tools-calculation")]
        public IActionResult Calculation()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tien-ich/truy-van-so-tiet-kiem")]
        [Route("support/utility/saving-account-inquiry")]
        public IActionResult AccountInquiry()
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
        [Route("san-pham/{list}")]
        [Route("product/{list}")]
        public IActionResult ListProduct(string list)
        {
            return View();
        }

        [HttpGet]
        [Route("san-pham/{list}/{detail}")]
        [Route("product/{list}/{detail}")]
        public IActionResult ProductDetail(string list,string detail)
        {
            return View();
        }
    }
}