using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("ho-tro")]
    [Route("support")]
    public class SupportController : BaseMvcController
    {
        private readonly ISupportService _supportService;
        public SupportController(ISupportService supportService)
        {
            _supportService = supportService;
        }

        [HttpGet]
        [Route("")]
        [Route("cau-hoi-thuong-gap")]
        [Route("faq-s")]
        public async Task<IActionResult> Index()
        {
            var faqs = await _supportService.GetFaqs(42,GetLangCurrent());
            ViewData["Title"] = faqs.Title;
            return View(faqs);
        }
    }
}