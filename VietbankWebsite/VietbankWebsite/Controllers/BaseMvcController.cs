using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace VietbankWebsite.Controllers
{
    public class BaseMvcController : Controller
    {
        public MemoryCacheEntryOptions cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(10));
        [Route("GetLangCurrent")]
        public string GetLangCurrent()
        {
            return Request.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.Name;
        }
    }
}