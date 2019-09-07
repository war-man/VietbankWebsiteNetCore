﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/home")]
    [ApiController]
    public class ApiHomeController : BaseApiController
    {
        private IMemoryCache _cache;
        private readonly IHomeService _homeService;
        public ApiHomeController(IMemoryCache memoryCache,IHomeService homeService)
        {
            _cache = memoryCache;
            _homeService = homeService;
        }

        [HttpGet("getbanner")]
        public async Task<IEnumerable<VbBanner>> GetBanner()
        {
            var keyBanner = GetLangCurrent() == "vi" ? CacheKeys.BannerVi : CacheKeys.BannerEn;
            IEnumerable<VbBanner> banner;
            if (!_cache.TryGetValue(keyBanner, out banner))
            {
                banner = await _homeService.GetBanner(GetLangCurrent());
                _cache.Set(keyBanner, banner, cacheEntryOptions);
            }
            return banner;
        }

        [HttpGet("search")]
        public async Task<IEnumerable<SearchInfor>> Search(string key)
        {
            return await _homeService.GetSearchInfors(key);
        }
    }
}