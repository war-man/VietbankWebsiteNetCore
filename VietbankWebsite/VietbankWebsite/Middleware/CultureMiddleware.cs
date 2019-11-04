using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System;
using System.Threading.Tasks;

namespace VietbankWebsite.Middleware
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Cookies[CookieRequestCultureProvider.DefaultCookieName] == null)
            {
                httpContext.Response.Redirect("/Home/SetLanguage?culture=vi");
            }
            await _next(httpContext);
        }
    }
}
