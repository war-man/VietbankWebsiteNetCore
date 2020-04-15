using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiEnterpriseController : BaseApiController
    {
        private readonly IProductService _productService;
        private readonly IAboutVietbankService _aboutVietbankService;
        private readonly IStringLocalizer<ApiEnterpriseController> _localizer;
        public ApiEnterpriseController(IProductService productService, IStringLocalizer<ApiEnterpriseController> localizer, IAboutVietbankService aboutVietbankService)
        {
            _productService = productService;
            _localizer = localizer;
            _aboutVietbankService = aboutVietbankService;
        }

        [HttpGet("listproducttocategory/{alias}/{page}/{pageSize}")]
        public async Task<ProductShort> ListProductToCategory(string alias, int page, int pageSize)
        {
            return await _productService.ListProductShort(26, alias, $"{_localizer["ProductUrl"]}/{alias}", GetLangCurrent(), page, pageSize);
        }

        [HttpGet("getlistpromotionnews/{pageCurrent}/{pageSize}")]
        public async Task<ListNews> GetListPromotion(int pageCurrent, int pageSize)
        {
            return await _aboutVietbankService.GetListNews(1074, _localizer["PromotionNewsName"], _localizer["PromotionNewsUrl"], GetLangCurrent(), pageCurrent, pageSize);
        }

        [HttpGet("listproductrandom/{idCate}")]
        public async Task<IEnumerable<ListProductShort>> ListRandomProduct(int idCate)
        {
            return await _productService.ListRandomProduct(idCate, GetLangCurrent());
        }
    }
}