﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml;
using VietbankWebsite.Context;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    public class HomeController : BaseMvcController
    {
        private IMemoryCache _cache;
        private readonly IHomeService _homeService;
        private readonly IShareholderService _shareholderService;
        private readonly ICareersService _careersService;
        private readonly IStringLocalizer<HomeController> _localizer;
        private IRecaptchaService _recaptcha;
        public HomeController(
            IStringLocalizer<HomeController> localizer, 
            IMemoryCache memoryCache, 
            IHomeService homeService, 
            IShareholderService shareholderService, 
            ICareersService careersService, 
            IRecaptchaService recaptcha
        )
        {
            _cache = memoryCache;
            _localizer = localizer;
            _homeService = homeService;
            _shareholderService = shareholderService;
            _careersService = careersService;
            _recaptcha = recaptcha;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var keyBanner = GetLangCurrent() == "vi" ? CacheKeys.BannerVi : CacheKeys.BannerEn;
            BoxContainerHomePage boxContainer;
            if (!_cache.TryGetValue(keyBanner, out boxContainer))
            {
                boxContainer = new BoxContainerHomePage() { 
                    Banner = await _homeService.GetBanner(GetLangCurrent()),
                    Box = await _homeService.GetBoxContainer("box",GetLangCurrent()),
                    Between = await _homeService.GetBoxContainer("between", GetLangCurrent()),
                    News = await _homeService.GetBoxContainer("news", GetLangCurrent())
                };
                _cache.Set(keyBanner, boxContainer, cacheEntryOptions);
            }
            ViewData["Title"] = _localizer["Home"];
            ViewData["MetaDescription"] = _localizer["MetaDescription"];
            return View(boxContainer);
        }

        [HttpGet]
        [Route("tuyen-dung")]
        [Route("tuyen-dung/co-hoi-nghe-nghiep")]
        [Route("careers")]
        [Route("careers/carrer-opportunity")]
        public async Task<IActionResult> Careers()
        {
            var keyCareer = GetLangCurrent() == "vi" ? CacheKeys.CareerTemplateVi : CacheKeys.CareerTemplateEn;
            Careers career;
            if (!_cache.TryGetValue(keyCareer, out career))
            {
                career = await _careersService.GetCareerTemplate(23, _localizer["CareerOpportunityUrl"], GetLangCurrent());
                _cache.Set(keyCareer, career, cacheEntryOptions);
            }
            ViewData["Title"] = career.Title;
            return View(career);
        }

        [HttpGet]
        [Route("ve-vietbank/tuyen-dung/{career}")]
        [Route("about-vietbank/careers/{career}")]
        [Route("tuyen-dung/co-hoi-nghe-nghiep/{career}")]
        [Route("careers/carrer-opportunity/{career}")]
        public async Task<IActionResult> CareerDetail(string career)
        {
            CareerDetail careerDetail;
            if (!_cache.TryGetValue($"_careerDetail-{career}", out careerDetail))
            {
                careerDetail = await _careersService.GetCareerDetail(career, GetLangCurrent());
                _cache.Set($"_careerDetail-{career}", careerDetail, cacheEntryOptions);
            }
            ViewData["Title"] = careerDetail.Title;
            return View(careerDetail);
        }

        [HttpGet]
        [Route("tuyen-dung/huong-dan-nop-ho-so")]
        [Route("careers/guide")]
        public async Task<IActionResult> CareerGuide()
        {
            var keyCareerGuide = GetLangCurrent() == "vi" ? CacheKeys.CareerGuideVi : CacheKeys.CareerGuideEn;
            NewsDetail careerGuid;
            if (!_cache.TryGetValue(keyCareerGuide, out careerGuid))
            {
                careerGuid = await _careersService.GetCareerGuide("huong-dan-nop-ho-so", GetLangCurrent());
                _cache.Set(keyCareerGuide, careerGuid, cacheEntryOptions);
            }
            ViewData["Title"] = careerGuid.Title;
            return View(careerGuid);
        }

        [HttpGet]
        [Route("quan-he-co-dong")]
        [Route("shareholders")]
        public async Task<IActionResult> Shareholders()
        {
            var keyShareholderCategories = GetLangCurrent() == "vi" ? CacheKeys.ShareholderCategoriesVi : CacheKeys.ShareholderCategoriesEn;
            ShareholderCategory shareholderCategories;
            if (!_cache.TryGetValue(keyShareholderCategories, out shareholderCategories))
            {
                shareholderCategories = await _shareholderService.ShareholderCategories(_localizer["ShareholderUrl"], "quan-he-co-dong", GetLangCurrent());
                _cache.Set(keyShareholderCategories, shareholderCategories, cacheEntryOptions);
            }
            ViewData["Title"] = _localizer["Shareholder"];
            return View(shareholderCategories);
        }

        [HttpGet]
        [Route("quan-he-co-dong/{detail}")]
        [Route("shareholders/{detail}")]
        public async Task<IActionResult> ShareholdersDetail(string detail)
        {
            ShareholderDetail shareholderDetail;
            if (!_cache.TryGetValue($"_shareholderDetail-{detail}", out shareholderDetail))
            {
                shareholderDetail = await _shareholderService.ShareholderDetail("quan-he-co-dong", detail, GetLangCurrent());
                _cache.Set($"_shareholderDetail-{detail}", shareholderDetail, cacheEntryOptions);
            }
            ViewData["Title"] = shareholderDetail.Title;
            return View(shareholderDetail);
        }

        [HttpGet]
        [Route("chi-nhanh")]
        [Route("branches")]
        public IActionResult Branch()
        {
            ViewData["Title"] = _localizer["BranchName"];
            return View();
        }

        #region Extension
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect("/");
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Privacy(ContactModel model)
        {
            var recaptcha = await _recaptcha.Validate(Request);
            if (!recaptcha.success)
                ModelState.AddModelError("", "There was an error validating recatpcha. Please try again!");
            return View();
        }

        public IActionResult CacheTryGetValueSet()
        {
            DateTime cacheEntry;
            // Look for cache key.
            if (!_cache.TryGetValue("_Entry", out cacheEntry))
            {
                // Key not in cache, so get data.
                cacheEntry = DateTime.Now;
                // Save data in cache.
                _cache.Set("_Entry", cacheEntry, cacheEntryOptions);
            }

            return View(cacheEntry);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult NotFoundPage()
        {
            ViewData["Title"] = "Không tìm thấy trang";
            return View();
        }
        #endregion
    }
}
