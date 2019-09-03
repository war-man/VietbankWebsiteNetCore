using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("ca-nhan")]
    [Route("personal")]
    public class PersonalController : BaseMvcController
    {
        private readonly IProductService _productService;
        private readonly IStringLocalizer<PersonalController> _localizer;
        private readonly ISupportService _supportService;
        public PersonalController(IStringLocalizer<PersonalController> localizer, IProductService productService, ISupportService supportService)
        {
            _localizer = localizer;
            _productService = productService;
            _supportService = supportService;
        }
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
        [Route("ho-tro/cau-hoi-thuong-gap")]
        [Route("support/faqs")]
        public async Task<IActionResult> Faqs()
        {
            var faqs = await _supportService.GetFaqs(42, GetLangCurrent());
            ViewData["Title"] = faqs.Title;
            return View(faqs);
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tien-ich/ty-gia")]
        [Route("support/utility/foreign-exchange")]
        public IActionResult Exchange()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/lai-suat")]
        [Route("support/interest-rate")]
        public async Task<IActionResult> Interest()
        {
            var interestRate = await _supportService.GetInterestRate(56,GetLangCurrent());
            return View(interestRate);
        }

        [HttpGet]
        [Route("ho-tro/lai-suat-co-so")]
        [Route("support/interest-rate-basic")]
        public async Task<IActionResult> InterestBasic()
        {
            var interestBasic = await _supportService.GetInterestRate(55, GetLangCurrent());
            return View(interestBasic);
        }

        [HttpGet]
        [Route("ho-tro/bieu-mau")]
        [Route("support/forms-tariff")]
        public async Task<IActionResult> FormTariff()
        {
            var form = await _supportService.GetForm(45, GetLangCurrent());
            return View(form);
        }

        [HttpGet]
        [Route("ho-tro/bieu-phi")]
        [Route("support/tariff")]
        public async Task<IActionResult> Tariff()
        {
            var tariff = await _supportService.GetForm(1040, GetLangCurrent());
            return View(tariff);
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tinh-toan")]
        [Route("support/tools-calculation")]
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
        public async Task<IActionResult> Product()
        {
            var result = await _productService.ListCategoryProducts(5, _localizer["ProductUrl"],GetLangCurrent())??new CategoryProduct();
            return View(result);
        }

        [HttpGet]
        [Route("san-pham/{list}")]
        [Route("product/{list}")]
        public async Task<IActionResult> ListProduct(string list)
        {
            var result = await _productService.ListCategoryProducts(5,list, $"{_localizer["ProductUrl"]}", GetLangCurrent()) ?? new CategoryProduct();
            return View(result);
        }

        [HttpGet]
        [Route("san-pham/{cate}/{detail}")]
        [Route("product/{cate}/{detail}")]
        public async Task<IActionResult> ProductDetail(string cate, string detail)
        {
            var productDetail = await _productService.GetProductDetail(cate, _localizer["ProductUrl"], detail, GetLangCurrent());
            if (productDetail == null) return NotFound();
            ViewData["Title"] = productDetail.Title;
            ViewBag.PersonalName = _localizer["PersonalName"];
            ViewBag.PersonalUrl = _localizer["PersonalUrl"];
            ViewBag.ProductName = _localizer["ProductName"];
            ViewBag.ProductUrl = _localizer["ProductUrl"];
            return View(productDetail);
        }
    }
}