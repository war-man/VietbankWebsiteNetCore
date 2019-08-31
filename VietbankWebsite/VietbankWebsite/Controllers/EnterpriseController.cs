using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using VietbankWebsite.Entities;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("doanh-nghiep")]
    [Route("enterprise")]
    public class EnterpriseController : BaseMvcController
    {
        private readonly IProductService _productService;
        private readonly IStringLocalizer<EnterpriseController> _localizer;
        public EnterpriseController(IProductService productService, IStringLocalizer<EnterpriseController> localizer)
        {
            _productService = productService;
            _localizer = localizer;
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
        public async Task<IActionResult> Product()
        {
            var product = await _productService.ListCategoryProducts(26, _localizer["ProductUrl"], GetLangCurrent()) ?? new CategoryProduct();
            return View(product);
        }

        [HttpGet]
        [Route("san-pham/{list}")]
        [Route("product/{list}")]
        public async Task<IActionResult> ListProduct(string list)
        {
            var result = await _productService.ListCategoryProducts(26,list, $"{_localizer["ProductUrl"]}", GetLangCurrent()) ?? new CategoryProduct();
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
            ViewBag.EnterpriseName = _localizer["EnterpriseName"];
            ViewBag.EnterpriseUrl = _localizer["EnterpriseUrl"];
            ViewBag.ProductName = _localizer["ProductName"];
            ViewBag.ProductUrl = _localizer["ProductUrl"];
            return View(productDetail);
        }
    }
}