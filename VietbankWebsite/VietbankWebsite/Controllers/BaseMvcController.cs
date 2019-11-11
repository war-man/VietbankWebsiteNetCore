using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace VietbankWebsite.Controllers
{
    public class BaseMvcController : Controller
    {
        public MemoryCacheEntryOptions cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(10));
        [Route("GetLangCurrent")]
        public string GetLangCurrent()
        {
            return Request.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.Name??"vi";
        }
    }
}