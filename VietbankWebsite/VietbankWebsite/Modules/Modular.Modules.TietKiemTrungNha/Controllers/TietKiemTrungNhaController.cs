using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VietbankWebsite;
using VietbankWebsite.Entities;
using VietbankWebsite.Service;
using Wangkanai.Detection;

namespace Modular.Modules.TietKiemTrungNha.Controllers
{
    [Route("tiet-kiem-trung-nha")]
    public class TietKiemTrungNhaController: Controller
    {
        private readonly IDetection _detection;
        private IRecaptchaService _recaptcha;
        private readonly ISupportService _supportService;
        public TietKiemTrungNhaController(IDetection detection, IRecaptchaService recaptcha, ISupportService supportService)
        {
            _recaptcha = recaptcha;
            _detection = detection;
            _supportService = supportService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            switch (_detection.Device?.Type.ToString())
            {
                case "Mobile":
                    return View("Mobile");
                default:
                    return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(VbFeedBack model)
        {
            var recaptcha = await _recaptcha.Validate(Request);
            if (!recaptcha.success)
            {
                ModelState.AddModelError("", "Mã xác thực không đúng, Vui lòng thử lại");
                switch (_detection.Device?.Type.ToString())
                {
                    case "Mobile":
                        return View("Mobile");
                    default:
                        return View();
                }
            }
            model.ContentCustomer = String.Empty;
            model.IsDone = false;
            model.CreatedDate = DateTime.Now;
            await _supportService.RecieveFeedBack(model);
            return RedirectToAction("Success");
        }

        [HttpGet]
        [Route("thanh-cong")]
        public IActionResult Success()
        {
            return View("Thanks");
        }
    }
}
