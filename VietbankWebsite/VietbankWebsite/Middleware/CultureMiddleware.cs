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

                httpContext.Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("vi")),
                    new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );
                await _next(httpContext);
            }
            else
            {
                await _next(httpContext);
            }
        }
    }
}
