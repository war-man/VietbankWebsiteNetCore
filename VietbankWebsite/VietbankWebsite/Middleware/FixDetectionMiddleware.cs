using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Middleware
{
    public class FixDetectionMiddleware
    {
        public FixDetectionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        readonly RequestDelegate _next;

        public async Task Invoke(HttpContext context)
        {
            var userAgent = context.Request.Headers["User-Agent"].FirstOrDefault();

            if (userAgent == null)
            {
                context.Request.Headers["User-Agent"] = string.Empty;
            }

            await _next.Invoke(context);
        }
    }
}
