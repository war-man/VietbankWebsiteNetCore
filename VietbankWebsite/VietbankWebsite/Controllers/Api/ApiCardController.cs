using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCardController : BaseApiController
    {
        private readonly ICardService _cardService;
        private IMemoryCache _cache;
        public ApiCardController(ICardService cardService, IMemoryCache cache)
        {
            _cache = cache;
            _cardService = cardService;
        }

        [HttpGet("getpromotionpost/{pageCurrent}/{pageSize}")]
        public async Task<IncentivesPostTwoPagination> GetPromotionPost(int pageCurrent,int pageSize)
        {
            return await _cardService.GetPromotionPost(pageCurrent, pageSize, GetLangCurrent());
        }

        [HttpGet("getcategorymastercard")]
        public async Task<IEnumerable<IncentivesCateThreeFieldView>> GetCategoryMasterCard()
        {
            var keyCardMaster = GetLangCurrent() == "vi" ? CacheKeys.CardPromotionMasterVi : CacheKeys.CardPromotionMasterEn;
            IEnumerable<IncentivesCateThreeFieldView> cardPromotionMaster;
            if (!_cache.TryGetValue(keyCardMaster, out cardPromotionMaster))
            {
                cardPromotionMaster = await _cardService.GetCategoryMasterCard(GetLangCurrent());
                _cache.Set(keyCardMaster, cardPromotionMaster, cacheEntryOptions);
            }
            return cardPromotionMaster;
        }
    }
}