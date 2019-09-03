using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using VietbankWebsite.Entities;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBranchController : BaseApiController
    {
        private IMemoryCache _cache;
        private readonly IBranchService _branchService;
        public ApiBranchController(IBranchService branchService, IMemoryCache cache)
        {
            _cache = cache;
            _branchService = branchService;
        }

        [HttpGet("getprovince")]
        public async Task<IEnumerable<VbMapProvince>> GetVbMapProvinces()
        {
            var keyBranchProvince = GetLangCurrent() == "vi" ? CacheKeys.BranchProvinceVi : CacheKeys.BranchProvinceEn;
            IEnumerable<VbMapProvince> vbMapProvince;
            if (!_cache.TryGetValue(keyBranchProvince, out vbMapProvince))
            {
                vbMapProvince = await _branchService.GetVbMapProvinces();
                _cache.Set(keyBranchProvince, vbMapProvince, cacheEntryOptions);
            }
            return vbMapProvince;
        }

        [HttpGet("getdistrict/{province}")]
        public async Task<IEnumerable<VbMapDistrict>> GetMapDistricts(string province)
        {
            return await _branchService.GetMapDistricts(province);
        }

        [HttpGet("getalltransagencymap")]
        public async Task<IEnumerable<VbTransagencyMap>> GetAllTransagencyMap()
        {
            var keyAllTransagency = GetLangCurrent() == "vi" ? CacheKeys.AllTransagencyVi : CacheKeys.AllTransagencyEn;
            IEnumerable<VbTransagencyMap> allTransagencyMap;
            if (!_cache.TryGetValue(keyAllTransagency, out allTransagencyMap))
            {
                allTransagencyMap = await _branchService.GetAllTransagencyMap();
                _cache.Set(keyAllTransagency, allTransagencyMap, cacheEntryOptions);
            }
            return allTransagencyMap;
        }

        [HttpGet("filtertransagencymap/{province}/{district}")]
        public async Task<IEnumerable<VbTransagencyMap>> FilterTransagencyMap(string province, string district)
        {
            return await _branchService.FilterTransagencyMap(province,district);
        }
    }
}