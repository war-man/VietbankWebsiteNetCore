using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("ngan-hang-so")]
    [Route("digital-banking")]
    public class DigitalBankingController : BaseMvcController
    {
        private readonly IStringLocalizer<DigitalBankingController> _localizer;
        private IMemoryCache _cache;
        private readonly IProductService _productService;
        private readonly IAboutVietbankService _aboutVietbankService;
        public DigitalBankingController(
            IStringLocalizer<DigitalBankingController> localizer, 
            IMemoryCache cache,
            IProductService productService,
            IAboutVietbankService aboutVietbankService
        )
        {
            _localizer = localizer;
            _cache = cache;
            _productService = productService;
            _aboutVietbankService = aboutVietbankService;
        }
        [HttpGet]
        [Route("")]
        [Route("dich-vu-ngan-hang-so")]
        [Route("digital-banking-service")]
        public async Task<IActionResult> Product()
        {
            var keyProduct = GetLangCurrent() == "vi" ? CacheKeys.PersonalProductVi : CacheKeys.PersonalProductEn;
            CategoryProduct products;
            if (!_cache.TryGetValue(keyProduct, out products))
            {
                products = await _productService.ListCategoryProducts(1078, _localizer["DichVuNHSUrl"], GetLangCurrent()) ?? new CategoryProduct();
                _cache.Set(keyProduct, products, cacheEntryOptions);
            }
            ViewData["Title"] = products.Title;
            return View(products);
        }

        [HttpGet]
        [Route("dich-vu-ngan-hang-so/{list}")]
        [Route("digital-banking-service/{list}")]
        public async Task<IActionResult> ListProduct(string list)
        {
            var keyListProduct = GetLangCurrent() == "vi" ? $"{CacheKeys.PersonalProductVi}-{list}" : $"{CacheKeys.PersonalProductEn}-{list}";
            CategoryProduct categoryListProduct;
            if (!_cache.TryGetValue(keyListProduct, out categoryListProduct))
            {
                categoryListProduct = await _productService.ListCategoryProducts(1078, list, $"{_localizer["DichVuNHSUrl"]}", GetLangCurrent()) ?? new CategoryProduct();
                _cache.Set(keyListProduct, categoryListProduct, cacheEntryOptions);
            }
            ViewData["Title"] = categoryListProduct.Title;
            return View(categoryListProduct);
        }

        [HttpGet]
        [Route("dich-vu-ngan-hang-so/{cate}/{detail}")]
        [Route("digital-banking-service/{cate}/{detail}")]
        public async Task<IActionResult> ProductDetail(string cate, string detail)
        {
            var productDetail = await _productService.GetProductDetail(cate, _localizer["DichVuNHSUrl"], detail, GetLangCurrent());
            var nextPrevProduct = await _productService.NextAndPrevProduct(productDetail.Id, $"{_localizer["DichVuNHSUrl"]}/{cate}", GetLangCurrent());
            productDetail.PrevNextProduct = nextPrevProduct;
            ViewData["Title"] = productDetail.Title;
            ViewBag.DichVuNHS = _localizer["DichVuNHS"];
            ViewBag.DichVuNHSUrl = _localizer["DichVuNHSUrl"];
            ViewBag.NganHangSo = _localizer["NganHangSo"];
            ViewBag.NganHangSoUrl = _localizer["NganHangSoUrl"];
            ViewData["MetaTitle"] = productDetail.MetaTitle;
            ViewData["MetaDescription"] = productDetail.MetaDescription;
            ViewData["FeatureImage"] = productDetail.FeatureImage;
            return View(productDetail);
        }

        [HttpGet]
        [Route("chuong-trinh-khuyen-mai")]
        [Route("promotions")]
        public async Task<IActionResult> PromotionNews()
        {
            var keyPromotionNews = GetLangCurrent() == "vi" ? CacheKeys.PersonalPromotionNewsVi : CacheKeys.PersonalPromotionNewsEn;
            IEnumerable<TopThreeNewsToCate> topThreeNewsToCates;
            if (!_cache.TryGetValue(keyPromotionNews, out topThreeNewsToCates))
            {
                topThreeNewsToCates = await _aboutVietbankService.TopThreeNewsToCate(1077, _localizer["CTKhuyenMaiUrl"], GetLangCurrent());
                _cache.Set(keyPromotionNews, topThreeNewsToCates, cacheEntryOptions);
            }
            ViewData["Title"] = _localizer["CTKhuyenMai"];
            return View(topThreeNewsToCates);
        }

        [HttpGet]
        [Route("chuong-trinh-khuyen-mai/{news}")]
        [Route("promotions/{news}")]
        public async Task<IActionResult> PromotionNewsDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            ViewData["MetaTitle"] = newsDetail.MetaTitle;
            ViewData["MetaDescription"] = newsDetail.MetaDescription;
            ViewData["FeatureImage"] = newsDetail.FeatureImage;
            return View(newsDetail);
        }
    }
}