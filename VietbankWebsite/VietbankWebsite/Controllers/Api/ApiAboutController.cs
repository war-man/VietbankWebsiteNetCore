using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiAboutController : BaseApiController
    {
        private IMemoryCache _cache;
        private readonly IAboutVietbankService _aboutVietbankService;
        private readonly IStringLocalizer<ApiAboutController> _localizer;
        public ApiAboutController(IAboutVietbankService aboutVietbankService, IStringLocalizer<ApiAboutController> localizer, IMemoryCache cache)
        {
            _cache = cache;
            _aboutVietbankService = aboutVietbankService;
            _localizer = localizer;
        }

        [HttpGet("getlistvietbanknews/{pageCurrent}/{pageSize}")]
        public async Task<ListNews> GetListNew(int pageCurrent,int pageSize)
        {
            return await _aboutVietbankService.GetListNews(17, _localizer["VietbankNewsName"],_localizer["VietbankNewsUrl"], GetLangCurrent(), pageCurrent, pageSize);
        }

        [HttpGet("getlistpromotionnews/{pageCurrent}/{pageSize}")]
        public async Task<ListNews> GetListPromotion(int pageCurrent, int pageSize)
        {
            return await _aboutVietbankService.GetListNews(19, _localizer["PromotionNewsName"], _localizer["PromotionNewsUrl"], GetLangCurrent(), pageCurrent, pageSize);
        }

        [HttpGet("getlistvietbanktv/{pageCurrent}/{pageSize}")]
        public async Task<ListNews> GetListVietbankTv(int pageCurrent, int pageSize)
        {
            return await _aboutVietbankService.GetListNews(1069, _localizer["VietbankTvName"], _localizer["VietbankTvUrl"], GetLangCurrent(), pageCurrent, pageSize);
        }

        [HttpGet("getrandomlistvietbanknews")]
        public async Task<IEnumerable<RandomNewsVietbank>> RandomVietbankNews()
        {
            return await _aboutVietbankService.GetRamdomNewsToCategory(17, _localizer["VietbankNewsUrl"],GetLangCurrent());
        }

        [HttpGet("getrandomlistpromotionnews")]
        public async Task<IEnumerable<RandomNewsVietbank>> RandomPromotionNews()
        {
            return await _aboutVietbankService.GetRamdomNewsToCategory(19, _localizer["PromotionNewsUrl"], GetLangCurrent());
        }

        [HttpGet("getrandomlistvietbanktv")]
        public async Task<IEnumerable<RandomNewsVietbank>> RandomVietbankTv()
        {
            return await _aboutVietbankService.GetRamdomNewsToCategory(1069, _localizer["VietbankTvUrl"], GetLangCurrent());
        }

        [HttpGet("getbankcode")]
        public async Task<BankCodeDataTable> GetVbBankCode()
        {
            var keyBankCode = GetLangCurrent() == "vi" ? CacheKeys.AboutBankCodeVi : CacheKeys.AboutBankCodeEn;
            BankCodeDataTable bankCode;
            if (!_cache.TryGetValue(keyBankCode, out bankCode))
            {
                bankCode = await _aboutVietbankService.GetVbBankCodes();
                _cache.Set(keyBankCode, bankCode, cacheEntryOptions);
            }
            return bankCode;
        }
    }
}