using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("ca-nhan")]
    [Route("personal")]
    public class PersonalController : BaseMvcController
    {
        private IMemoryCache _cache;
        private readonly IProductService _productService;
        private readonly IStringLocalizer<PersonalController> _localizer;
        private readonly ISupportService _supportService;
        private readonly IAboutVietbankService _aboutVietbankService;
        public PersonalController(
            IStringLocalizer<PersonalController> localizer, 
            IProductService productService, 
            ISupportService supportService, 
            IMemoryCache cache, 
            IAboutVietbankService aboutVietbankService
        )
        {
            _cache = cache;
            _localizer = localizer;
            _productService = productService;
            _supportService = supportService;
            _aboutVietbankService = aboutVietbankService;
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
        [Route("tin-khuyen-mai")]
        [Route("promotion-new")]
        public async Task<IActionResult> PromotionNews()
        {
            var keyPromotionNews = GetLangCurrent() == "vi" ? CacheKeys.PersonalPromotionNewsVi : CacheKeys.PersonalPromotionNewsEn;
            IEnumerable<TopThreeNewsToCate> topThreeNewsToCates;
            if (!_cache.TryGetValue(keyPromotionNews, out topThreeNewsToCates))
            {
                topThreeNewsToCates = await _aboutVietbankService.TopThreeNewsToCate(1073, _localizer["PromotionNewsUrl"], GetLangCurrent());
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
            var keyPersonalFaqs = GetLangCurrent() == "vi" ? CacheKeys.PersonalFaqsEn : CacheKeys.PersonalFaqsEn;
            Faqs faqs;
            if (!_cache.TryGetValue(keyPersonalFaqs, out faqs))
            {
                faqs = await _supportService.GetFaqs(42, GetLangCurrent());
                _cache.Set(keyPersonalFaqs, faqs, cacheEntryOptions);
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
            var keyPersonalInterest = GetLangCurrent() == "vi" ? CacheKeys.PersonalInterestVi : CacheKeys.PersonalInterestEn;
            InterestRate interestRate;
            if (!_cache.TryGetValue(keyPersonalInterest, out interestRate))
            {
                interestRate = await _supportService.GetInterestRate(56, GetLangCurrent());
                _cache.Set(keyPersonalInterest, interestRate, cacheEntryOptions);
            }
            ViewData["Title"] = interestRate.Title;
            return View(interestRate);
        }

        [HttpGet]
        [Route("ho-tro/lai-suat-co-so")]
        [Route("support/interest-rate-basic")]
        public async Task<IActionResult> InterestBasic()
        {
            var keyPersonalInterestBasic = GetLangCurrent() == "vi" ? CacheKeys.PersonalInterestBasicVi : CacheKeys.PersonalInterestBasicEn;
            InterestRate interestRateBasic;
            if (!_cache.TryGetValue(keyPersonalInterestBasic, out interestRateBasic))
            {
                interestRateBasic = await _supportService.GetInterestRate(55, GetLangCurrent());
                _cache.Set(keyPersonalInterestBasic, interestRateBasic, cacheEntryOptions);
            }
            ViewData["Title"] = interestRateBasic.Title;
            return View(interestRateBasic);
        }

        [HttpGet]
        [Route("ho-tro/bieu-mau")]
        [Route("support/forms")]
        public async Task<IActionResult> FormTariff()
        {
            var keyPersonalFormTariff = GetLangCurrent() == "vi" ? CacheKeys.PersonalFormTariffVi : CacheKeys.PersonalFormTariffEn;
            Form formTariff;
            if (!_cache.TryGetValue(keyPersonalFormTariff, out formTariff))
            {
                formTariff = await _supportService.GetForm(45, GetLangCurrent());
                _cache.Set(keyPersonalFormTariff, formTariff, cacheEntryOptions);
            }
            ViewData["Title"] = formTariff.Title;
            return View(formTariff);
        }

        [HttpGet]
        [Route("ho-tro/bieu-phi")]
        [Route("support/tariff")]
        public async Task<IActionResult> Tariff()
        {
            var keyPersonalTariff = GetLangCurrent() == "vi" ? CacheKeys.PersonalTariffVi : CacheKeys.PersonalTariffEn;
            Form tariff;
            if (!_cache.TryGetValue(keyPersonalTariff, out tariff))
            {
                tariff = await _supportService.GetForm(1040, GetLangCurrent());
                _cache.Set(keyPersonalTariff, tariff, cacheEntryOptions);
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
        [Route("ho-tro/truy-van-so-tiet-kiem")]
        [Route("support/saving-account-inquiry")]
        public async Task<IActionResult> AccountInquiry()
        {
            var keyAccountInquiry = GetLangCurrent() == "vi" ? CacheKeys.PersonalAccountInquiryVi : CacheKeys.PersonalAccountInquiryEn;
            Form accountInquiry;
            if (!_cache.TryGetValue(keyAccountInquiry, out accountInquiry))
            {
                accountInquiry = await _supportService.GetForm(1066, GetLangCurrent());
                _cache.Set(keyAccountInquiry, accountInquiry, cacheEntryOptions);
            }
            ViewData["Title"] = accountInquiry.Title;
            return View(accountInquiry);
        }

        [HttpGet]
        [Route("")]
        [Route("san-pham")]
        [Route("product")]
        public async Task<IActionResult> Product()
        {
            var keyProduct = GetLangCurrent() == "vi" ? CacheKeys.PersonalProductVi : CacheKeys.PersonalProductEn;
            CategoryProduct products;
            if (!_cache.TryGetValue(keyProduct, out products))
            {
                products = await _productService.ListCategoryProducts(5, _localizer["ProductUrl"], GetLangCurrent()) ?? new CategoryProduct();
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
            var keyListProduct = GetLangCurrent() == "vi" ? $"{CacheKeys.PersonalProductVi}-{list}" : $"{CacheKeys.PersonalProductEn}-{list}";
            CategoryProduct categoryListProduct;
            if (!_cache.TryGetValue(keyListProduct, out categoryListProduct))
            {
                categoryListProduct = await _productService.ListCategoryProducts(5, list, $"{_localizer["ProductUrl"]}", GetLangCurrent()) ?? new CategoryProduct();
                _cache.Set(keyListProduct, categoryListProduct, cacheEntryOptions);
            }
            ViewData["Title"] = categoryListProduct.Title;
            return View(categoryListProduct);
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