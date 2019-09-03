using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VietbankWebsite.Entities;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCareerController : BaseApiController
    {
        private readonly ICareersService _careersService;
        public ApiCareerController(ICareersService careersService)
        {
            _careersService = careersService;
        }

        [HttpGet("searchcareer")]
        public async Task<IEnumerable<CareerJobList>> SearchCareer(string key,int city,int major)
        {
            var aliasCareer = GetLangCurrent() == "vi" ? "/tuyen-dung/co-hoi-nghe-nghiep" : "/careers/career-opportunity";
            var resultSearch = await _careersService.SearchCareer(key, city, major, aliasCareer);
            return resultSearch == null?new List<CareerJobList>():resultSearch;
        }
    }
}