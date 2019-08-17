using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/home")]
    [ApiController]
    public class ApiHomeController : BaseApiController
    {
        private IMemoryCache _cache;
        private readonly IVbBannerService _vbBannerService;
        public ApiHomeController(IMemoryCache memoryCache,IVbBannerService vbBannerService)
        {
            _cache = memoryCache;
            _vbBannerService = vbBannerService;
        }

        [HttpGet("getbanner")]
        public async Task<IEnumerable<VbBanner>> GetBanner()
        {
            var keyBanner = GetLangCurrent() == "vi" ? CacheKeys.BannerVi : CacheKeys.BannerEn;
            IEnumerable<VbBanner> banner;
            if (!_cache.TryGetValue(keyBanner, out banner))
            {
                banner = await _vbBannerService.GetBanner(GetLangCurrent());
                _cache.Set(keyBanner, banner, cacheEntryOptions);
            }
            return banner;
        }
    }
}