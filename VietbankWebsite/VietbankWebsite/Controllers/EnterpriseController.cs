using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("doanh-nghiep")]
    [Route("enterprise")]
    public class EnterpriseController : BaseMvcController
    {
        private IMemoryCache _cache;
        private IRecaptchaService _recaptcha;
        private readonly IProductService _productService;
        private readonly IStringLocalizer<EnterpriseController> _localizer;
        private readonly ISupportService _supportService;
        private readonly IAboutVietbankService _aboutVietbankService;
        private readonly RemoteService _remoteService;
        public EnterpriseController(
            IProductService productService, 
            IStringLocalizer<EnterpriseController> localizer, 
            ISupportService supportService, 
            IMemoryCache cache, 
            IRecaptchaService recaptcha,
            IAboutVietbankService aboutVietbankService,
            IOptions<RemoteService> remoteService
        )
        {
            _cache = cache;
            _productService = productService;
            _localizer = localizer;
            _supportService = supportService;
            _recaptcha = recaptcha;
            _aboutVietbankService = aboutVietbankService;
            _remoteService = remoteService.Value;
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
        [Route("tin-khuyen-mai")]
        [Route("promotions-news")]
        public async Task<IActionResult> PromotionNews()
        {
            var keyPromotionNews = GetLangCurrent() == "vi" ? CacheKeys.EnterprisePromotionNewsVi : CacheKeys.EnterprisePromotionNewsEn;
            IEnumerable<TopThreeNewsToCate> topThreeNewsToCates;
            if (!_cache.TryGetValue(keyPromotionNews, out topThreeNewsToCates))
            {
                topThreeNewsToCates = await _aboutVietbankService.TopThreeNewsToCate(1072, _localizer["PromotionNewsUrl"], GetLangCurrent());
                _cache.Set(keyPromotionNews, topThreeNewsToCates, cacheEntryOptions);
            }
            return View(topThreeNewsToCates);
        }

        [HttpGet]
        [Route("tin-khuyen-mai/{news}")]
        [Route("promotions-news/{news}")]
        public async Task<IActionResult> PromotionNewsDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            return View(newsDetail);
        }

        [HttpGet]
        [Route("ho-tro")]
        [Route("support")]
        [Route("ho-tro/cau-hoi-thuong-gap")]
        [Route("support/faqs")]
        public async Task<IActionResult> Faqs()
        {
            var keyEnterpriseFaqs = GetLangCurrent() == "vi" ? CacheKeys.EnterpriseFaqsVi : CacheKeys.EnterpriseFaqsEn;
            Faqs faqs;
            if (!_cache.TryGetValue(keyEnterpriseFaqs, out faqs))
            {
                faqs = await _supportService.GetFaqs(51, GetLangCurrent());
                _cache.Set(keyEnterpriseFaqs, faqs, cacheEntryOptions);
            }
            ViewData["Title"] = faqs.Title;
            return View(faqs);
        }

        [HttpGet]
        [Route("ho-tro/ty-gia")]
        [Route("support/foreign-exchange")]
        public IActionResult Exchange()
        {
            return View();
        }

        [HttpGet]
        [Route("ho-tro/lai-suat")]
        [Route("support/interest-rate")]
        public async Task<IActionResult> Interest()
        {
            var keyEnterpriseInterest = GetLangCurrent() == "vi" ? CacheKeys.EnterpriseInterestVi : CacheKeys.EnterpriseInterestEn;
            InterestRate interestRate;
            if (!_cache.TryGetValue(keyEnterpriseInterest, out interestRate))
            {
                interestRate = await _supportService.GetInterestRate(1049, GetLangCurrent());
                _cache.Set(keyEnterpriseInterest, interestRate, cacheEntryOptions);
            }
            ViewData["Title"] = interestRate.Title;
            return View(interestRate);
        }

        [HttpGet]
        [Route("ho-tro/lai-suat-co-so")]
        [Route("support/interest-rate-basic")]
        public async Task<IActionResult> InterestBasic()
        {
            var keyEnterpriseInterestBasic = GetLangCurrent() == "vi" ? CacheKeys.EnterpriseInterestBasicVi : CacheKeys.EnterpriseInterestBasicEn;
            InterestRate interestRateBasic;
            if (!_cache.TryGetValue(keyEnterpriseInterestBasic, out interestRateBasic))
            {
                interestRateBasic = await _supportService.GetInterestRate(1049, GetLangCurrent());
                _cache.Set(keyEnterpriseInterestBasic, interestRateBasic, cacheEntryOptions);
            }
            ViewData["Title"] = interestRateBasic.Title;
            return View(interestRateBasic);
        }

        [HttpGet]
        [Route("ho-tro/bieu-mau")]
        [Route("support/forms")]
        public async Task<IActionResult> FormTariff()
        {
            var keyEnterpriseFormTariff = GetLangCurrent() == "vi" ? CacheKeys.EnterpriseFormTariffVi : CacheKeys.EnterpriseFormTariffEn;
            Form formTariff;
            if (!_cache.TryGetValue(keyEnterpriseFormTariff, out formTariff))
            {
                formTariff = await _supportService.GetForm(54, GetLangCurrent());
                _cache.Set(keyEnterpriseFormTariff, formTariff, cacheEntryOptions);
            }
            ViewData["Title"] = formTariff.Title;
            return View(formTariff);
        }

        [HttpGet]
        [Route("ho-tro/bieu-phi")]
        [Route("support/tariff")]
        public async Task<IActionResult> Tariff()
        {
            var keyEnterpriseTariff = GetLangCurrent() == "vi" ? CacheKeys.EnterpriseTariffVi : CacheKeys.EnterpriseTariffEn;
            Form tariff;
            if (!_cache.TryGetValue(keyEnterpriseTariff, out tariff))
            {
                tariff = await _supportService.GetForm(1041, GetLangCurrent());
                _cache.Set(keyEnterpriseTariff, tariff, cacheEntryOptions);
            }
            ViewData["Title"] = tariff.Title;
            return View(tariff);
        }

        [HttpGet]
        [Route("ho-tro/cong-cu-tinh-toan")]
        [Route("support/tools-calculators")]
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
        [Route("ho-tro/xac-thuc-thu-bao-lanh")]
        [Route("support/guarantee-letter")]
        public IActionResult GuaranteeLetter()
        {
            return View();
        }

        [HttpPost]
        [Route("ho-tro/xac-thuc-thu-bao-lanh")]
        [Route("support/guarantee-letter")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GuaranteeLetter(GuaranteelLetter model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var recaptcha = await _recaptcha.Validate(Request);
            if (!recaptcha.success)
            {
                ModelState.AddModelError("", "Mã xác thực không đúng, Vui lòng thử lại");
                return View(model);
            }
            ViewData["GuaranteeLetter"] = GenerateTableGuaranteeLetter(await _supportService.GetRemoteGuaranteeLetter(_remoteService.ITS,model.acctNbr,model.seriesNo));
            return View(model);
        }

        private string GenerateTableGuaranteeLetter(ThuBaoLanhModel thuBaoLanh)
        {
            string guaranteeLetter = $"<table class='table table-hover' style='padding-bottom: 14px;'>" +
                    $"<thead><tr><th colspan='3'>{_localizer["ThuBaoLanhName"]}</th></tr></thead>" +
                    "<tbody>" +
                        $"<tr><td>{_localizer["ThuBaoLanhSTK"]}</td><td>{thuBaoLanh.ACCTNBR}</td></tr>" +
                        $"<tr><td>{_localizer["ThuBaoLanhSeri"]}</td><td>{thuBaoLanh.SERIES}</td></tr>" +
                        $"<tr><td>{_localizer["ThuBaoLanhPublish"]}</td><td>{thuBaoLanh.DATE_EFF}</td></tr>" +
                        $"<tr><td>{_localizer["ThuBaoLanhValue"]}</td><td>{thuBaoLanh.CURRENTBALANCE} VND</td></tr>" +
                        $"<tr><td>{_localizer["ThuBaoLanhCompany"]}</td><td>{thuBaoLanh.HOTEN}</td></tr>" +
                        $"<tr><td>{_localizer["ThuBaoLanhActive"]}</td><td>{thuBaoLanh.ISVALID}</td></tr>" +
                        $"<tr><td>{_localizer["ThuBaoLanhContent"]}</td><td><a href='http://static.vietbank.com.vn/web/ThuBaoLanh/{thuBaoLanh.FILESCANURL}' target='_blank'>{_localizer["ThuBaoLanhViewLetter"]}</a></td></tr>" +
                    "</tbody>" +
                "</table>";
            return guaranteeLetter;
        }

        [HttpGet]
        [Route("")]
        [Route("san-pham")]
        [Route("product")]
        public async Task<IActionResult> Product()
        {
            var keyProduct = GetLangCurrent() == "vi" ? CacheKeys.EnterpriseProductVi : CacheKeys.EnterpriseProductEn;
            CategoryProduct products;
            if (!_cache.TryGetValue(keyProduct, out products))
            {
                products = await _productService.ListCategoryProducts(26, _localizer["ProductUrl"], GetLangCurrent()) ?? new CategoryProduct();
                _cache.Set(keyProduct, products, cacheEntryOptions);
            }
            ViewData["Title"] = products.Title;
            return View(products);
        }

        [HttpGet]
        [Route("san-pham/{list}")]
        [Route("product/{list}")]
        public async Task<IActionResult> ListProduct(string list)
        {
            var keyListProduct = GetLangCurrent() == "vi" ? $"{CacheKeys.EnterpriseProductVi}-{list}" : $"{CacheKeys.EnterpriseProductEn}-{list}";
            CategoryProduct listProduct;
            if (!_cache.TryGetValue(keyListProduct, out listProduct))
            {
                listProduct = await _productService.ListCategoryProducts(26, list, $"{_localizer["ProductUrl"]}", GetLangCurrent()) ?? new CategoryProduct();
                _cache.Set(keyListProduct, listProduct, cacheEntryOptions);
            }
            ViewData["Title"] = listProduct.Title;
            return View(listProduct);
        }

        [HttpGet]
        [Route("san-pham/{cate}/{detail}")]
        [Route("product/{cate}/{detail}")]
        public async Task<IActionResult> ProductDetail(string cate, string detail)
        {
            var productDetail = await _productService.GetProductDetail(cate, _localizer["ProductUrl"], detail, GetLangCurrent());
            productDetail.PrevNextProduct = await _productService.NextAndPrevProduct(productDetail.Id, $"{_localizer["ProductUrl"]}/{cate}", GetLangCurrent());
            ViewData["Title"] = productDetail.Title;
            ViewBag.EnterpriseName = _localizer["EnterpriseName"];
            ViewBag.EnterpriseUrl = _localizer["EnterpriseUrl"];
            ViewBag.ProductName = _localizer["ProductName"];
            ViewBag.ProductUrl = _localizer["ProductUrl"];
            ViewData["MetaTitle"] = productDetail.MetaTitle;
            ViewData["MetaDescription"] = productDetail.MetaDescription;
            ViewData["FeatureImage"] = productDetail.FeatureImage;
            return View(productDetail);
        }
    }
}