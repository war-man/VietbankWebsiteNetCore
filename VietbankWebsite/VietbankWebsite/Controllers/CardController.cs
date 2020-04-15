using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Repository;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("the")]
    [Route("card")]
    public class CardController : BaseMvcController
    {
        private readonly ICardService _cardService;
        private IMemoryCache _cache;
        private readonly ExternalService _externalService;
        private IRecaptchaService _recaptcha;
        private readonly IEmailSenderRepository _emailSenderRepository;
        private readonly IRazorViewToStringRenderer _razorViewToStringRenderer;
        public CardController(
            ICardService cardService, 
            IMemoryCache cache, 
            IOptions<ExternalService> externalService, 
            IRecaptchaService recaptcha,
            IEmailSenderRepository emailSenderRepository,
            IRazorViewToStringRenderer razorViewToStringRenderer
            )
        {
            _cache = cache;
            _cardService = cardService;
            _externalService = externalService.Value;
            _recaptcha = recaptcha;
            _emailSenderRepository = emailSenderRepository;
            _razorViewToStringRenderer = razorViewToStringRenderer;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var keyCardHome = GetLangCurrent() == "vi" ? CacheKeys.CardHomeVi : CacheKeys.CardHomeEn;
            CardHomeTemplate cardHomeTemplate;
            if (!_cache.TryGetValue(keyCardHome, out cardHomeTemplate))
            {
                cardHomeTemplate = await _cardService.GetCardHome(GetLangCurrent());
                _cache.Set(keyCardHome, cardHomeTemplate, cacheEntryOptions);
            }
            ViewData["Title"] = GetLangCurrent() == "vi" ? "Thẻ tín dụng Vietbank - Ngân hàng Vietnam Thương Tín" : "Credit Card Vietbank";
            return View(cardHomeTemplate);
        }

        [HttpGet]
        [Route("san-pham")]
        [Route("product")]
        public async Task<IActionResult> Product()
        {
            var keyCardProductHome = GetLangCurrent() == "vi" ? CacheKeys.CardProductHomeVi : CacheKeys.CardProductHomeEn;
            CardProductHomeDto cardProductHomeDto;
            if (!_cache.TryGetValue(keyCardProductHome, out cardProductHomeDto))
            {
                cardProductHomeDto = await _cardService.GetCardProductHome(GetLangCurrent());
                _cache.Set(keyCardProductHome, cardProductHomeDto, cacheEntryOptions);
            }
            ViewData["Title"] = cardProductHomeDto.Title;
            return View(cardProductHomeDto);
        }

        [HttpGet]
        [Route("san-pham/{detail}")]
        [Route("product/{detail}")]
        public async Task<IActionResult> ProductDetail(string detail)
        {
            CardProductDetailDto cardProductDetailDto;
            if (!_cache.TryGetValue(detail, out cardProductDetailDto))
            {
                cardProductDetailDto = await _cardService.GetCardProductDetail(detail, GetLangCurrent());
                _cache.Set(detail, cardProductDetailDto, cacheEntryOptions);
            }
            ViewData["Title"] = cardProductDetailDto.TitleTwoBoxOne;
            return View(cardProductDetailDto);
        }

        [HttpGet]
        [Route("ho-tro")]
        [Route("support")]
        [Route("ho-tro/{alias}")]
        [Route("support/{alias}")]
        [Route("ho-tro/nhung-cau-hoi-thuong-gap/{alias}")]
        [Route("support/frequently-asked-questions/{alias}")]
        public async Task<IActionResult> Forms(string alias)
        {
            if (alias == null)
            {
                alias = GetLangCurrent() == "vi"?"bieu-mau":"forms";
            }
            CardSupportPostView cardSupport;
            if (!_cache.TryGetValue($"_carSuport-{alias}", out cardSupport))
            {
                cardSupport = await _cardService.GetCardSupport(alias, GetLangCurrent());
                _cache.Set($"_carSuport-{alias}", cardSupport, cacheEntryOptions);
            }
            ViewData["Title"] = cardSupport.TitleBanner;
            return View(cardSupport);
        }

        [HttpGet]
        [Route("uu-dai/chuong-trinh-khuyen-mai")]
        [Route("incentives/promotions")]
        public async Task<IActionResult> Promotions()
        {
            var keyCardPromotion = GetLangCurrent() == "vi" ? CacheKeys.CardPromotionVi : CacheKeys.CardPromotionEn;
            IncentivesCateTwoDto incentivesCateTwoDto;
            if (!_cache.TryGetValue(keyCardPromotion, out incentivesCateTwoDto))
            {
                incentivesCateTwoDto = await _cardService.GetCardPromotion(GetLangCurrent());
                _cache.Set(keyCardPromotion, incentivesCateTwoDto, cacheEntryOptions);
            }
            ViewData["Title"] = incentivesCateTwoDto.Title;
            return View(incentivesCateTwoDto);
        }

        [HttpGet]
        [Route("uu-dai/chuong-trinh-khuyen-mai/{detail}")]
        [Route("incentives/promotions/{detail}")]
        public async Task<IActionResult> PromotionDetail(string detail)
        {
            var keyPromotionDetail = $"_promotion_detail_{detail}";
            IncentivesPostTwoDto incentivesPostTwoDto;
            if (!_cache.TryGetValue(keyPromotionDetail, out incentivesPostTwoDto))
            {
                incentivesPostTwoDto = await _cardService.GetPromotionDetail(detail,GetLangCurrent());
                _cache.Set(keyPromotionDetail, incentivesPostTwoDto, cacheEntryOptions);
            }
            ViewData["Title"] = incentivesPostTwoDto.Title;
            return View(incentivesPostTwoDto);
        }

        [HttpGet]
        [Route("uu-dai/uu-dai-danh-cho-chu-the")]
        [Route("incentives/promotions-of-master-card")]
        public async Task<IActionResult> HappyDay()
        {
            var keyCardPromotionMaster = GetLangCurrent() == "vi" ? CacheKeys.CardPromotionMasterVi : CacheKeys.CardPromotionMasterEn;
            IncentivesCateThreeDto incentivesCateThreeDto;
            if (!_cache.TryGetValue(keyCardPromotionMaster, out incentivesCateThreeDto))
            {
                incentivesCateThreeDto = await _cardService.GetMasterCard(GetLangCurrent());
                _cache.Set(keyCardPromotionMaster, incentivesCateThreeDto, cacheEntryOptions);
            }
            ViewData["Title"] = incentivesCateThreeDto.Name;
            return View(incentivesCateThreeDto);
        }


        [HttpGet]
        [Route("dang-ky")]
        [Route("registry")]
        public IActionResult Registry()
        {
            return View();
        }

        [HttpPost]
        [Route("dang-ky")]
        [Route("registry")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registry(CardRegistry model)
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
            _emailSenderRepository.SendMail(model.Email, "Đăng ký thẻ Vietbank", await _razorViewToStringRenderer.RenderViewToStringAsync("/Views/EmailSender/ContactResponseToUser.cshtml", new ContactResponseToUser()
            {
                Message = "Vietbank đã nhận được thông tin đang ký thẻ của bạn, chúng tôi sẽ liên hệ với bạn trong thời gian sớm nhất!"
            }));
            TempData["success"] = await _cardService.CardOnlineRegister(_externalService.ThamDinhThe, new CustomerInfo()
            {
                HoTen = model.HoTen,
                DienThoai = model.DienThoai,
                Email = model.Email,
                GioiTinh = model.GioiTinh,
                LoaiGiayTo = model.LoaiGiayTo,
                SoGiayTo= model.SoGiayTo,
                BranchId = model.BranchId,
                Status = 1,
                IsOnline = "Y",
                Tinh = model.Tinh
            });
            return View();
        }
    }
}