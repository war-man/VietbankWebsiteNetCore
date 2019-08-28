using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    public class HomeController : BaseMvcController
    {
        private IMemoryCache _cache;
        private readonly IVbBannerService _vbBannerService;
        private readonly IShareholderService _shareholderService;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(IStringLocalizer<HomeController> localizer, IMemoryCache memoryCache, IVbBannerService vbBannerService, IShareholderService shareholderService)
        {
            _cache = memoryCache;
            _localizer = localizer;
            _vbBannerService = vbBannerService;
            _shareholderService = shareholderService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var keyBanner = GetLangCurrent() == "vi" ? CacheKeys.BannerVi : CacheKeys.BannerEn;
            IEnumerable<VbBanner> banner;
            if (!_cache.TryGetValue(keyBanner, out banner))
            {
                banner = await _vbBannerService.GetBanner(GetLangCurrent());
                _cache.Set(keyBanner, banner, cacheEntryOptions);
            }
            ViewData["Title"] = _localizer["Home"];
            return View(banner);
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
            var shareholderDetail = await _shareholderService.ShareholderDetail("quan-he-co-dong", detail, GetLangCurrent());
            if (shareholderDetail == null) return RedirectToAction(nameof(NotFoundPage));
            ViewData["Title"] = shareholderDetail.Title;
            return View(shareholderDetail);
        }

        [HttpGet]
        [Route("cong-cu/chi-nhanh")]
        [Route("tools/branch")]
        public IActionResult Branch(string detail)
        {
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NotFoundPage()
        {
            ViewData["Title"] = "Không tìm thấy trang";
            return View();
        }
        #endregion
    }
}
