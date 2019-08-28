using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("the")]
    [Route("card")]
    public class CardController : BaseMvcController
    {
        private readonly ICardService _cardService;
        private IMemoryCache _cache;
        public CardController(ICardService cardService, IMemoryCache cache)
        {
            _cache = cache;
            _cardService = cardService;
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
        [Route("ho-tro/bieu-mau")]
        [Route("support/forms")]
        public IActionResult Forms()
        {
            return View();
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
        [Route("incentives/happy-day")]
        public IActionResult HappyDay()
        {
            return View();
        }
    }
}