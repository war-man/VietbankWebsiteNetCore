using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiPersonalController : BaseApiController
    {
        private readonly IProductService _productService;
        private readonly IAboutVietbankService _aboutVietbankService;
        private readonly IStringLocalizer<ApiPersonalController> _localizer;
        public ApiPersonalController(IProductService productService, IStringLocalizer<ApiPersonalController> localizer, IAboutVietbankService aboutVietbankService)
        {
            _productService = productService;
            _localizer = localizer;
            _aboutVietbankService = aboutVietbankService;
        }
        [HttpGet("listproducttocategory/{alias}/{page}/{pageSize}")]
        public async Task<ProductShort> ListProductToCategory(string alias,int page,int pageSize)
        {
            return await _productService.ListProductShort(5,alias,$"{_localizer["ProductUrl"]}/{alias}",GetLangCurrent(), page, pageSize);
        }

        [HttpGet("getlistpromotionnews/{pageCurrent}/{pageSize}")]
        public async Task<ListNews> GetListPromotion(int pageCurrent, int pageSize)
        {
            return await _aboutVietbankService.GetListNews(1073, _localizer["PromotionNewsName"], _localizer["PromotionNewsUrl"], GetLangCurrent(), pageCurrent, pageSize);
        }
    }
}