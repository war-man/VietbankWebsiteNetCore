using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiDigitalBankingController : BaseApiController
    {
        private readonly IProductService _productService;
        private readonly IStringLocalizer<ApiDigitalBankingController> _localizer;
        public ApiDigitalBankingController(IProductService productService, IStringLocalizer<ApiDigitalBankingController> localizer)
        {
            _productService = productService;
            _localizer = localizer;
        }
        [HttpGet("listproducttocategory/{alias}/{page}/{pageSize}")]
        public async Task<ProductShort> ListProductToCategory(string alias, int page, int pageSize)
        {
            return await _productService.ListProductShort(1078, alias, $"{alias}", GetLangCurrent(), page, pageSize);
        }
    }
}