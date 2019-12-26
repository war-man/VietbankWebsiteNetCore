using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;

namespace VietbankWebsite.Controllers
{
    [Route("tracuuhoadon")]
    public class TraCuuHoaDonController : Controller
    {
        private readonly RemoteService _remoteService;
        private IRecaptchaService _recaptcha;
        public TraCuuHoaDonController(IOptions<RemoteService> remoteService, IRecaptchaService recaptcha)
        {
            _remoteService = remoteService.Value;
            _recaptcha = recaptcha;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(BillLookUpRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var recaptcha = await _recaptcha.Validate(Request);
            if (!recaptcha.success)
            {
                ModelState.AddModelError("", "Mã xác thực không đúng, Vui lòng thử lại");
                return View(model);
            }
            var resultBillLookUp = await GetRemoteBillLookUp(_remoteService.BillLookUp, model.BillCode);
            ViewData["BillResult"] = resultBillLookUp.GetInvoiceResult;
            return View(model);
        }

        private async Task<BillLookUpResponse> GetRemoteBillLookUp(string urlRemote, string billCode)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(new BillLookUpParam() { MaTraCuu = billCode }), Encoding.UTF8, "application/json");
                HttpResponseMessage result = await client.PostAsync(urlRemote, content);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<BillLookUpResponse>(response);
                }
                return new BillLookUpResponse();
            }
        }
    }
}