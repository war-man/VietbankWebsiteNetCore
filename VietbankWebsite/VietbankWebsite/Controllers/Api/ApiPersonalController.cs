using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiPersonalController : BaseApiController
    {
        private readonly IPersonalService _personalService;
        private readonly IStringLocalizer<ApiPersonalController> _localizer;
        public ApiPersonalController(IPersonalService personalService, IStringLocalizer<ApiPersonalController> localizer)
        {
            _personalService = personalService;
            _localizer = localizer;
        }
        [HttpGet("listproducttocategory/{alias}/{page}/{pageSize}")]
        public async Task<ProductShort> ListProductToCategory(string alias,int page,int pageSize)
        {
            return await _personalService.ListProductShort(alias,$"{_localizer["ProductUrl"]}/{alias}",GetLangCurrent(), page, pageSize);
        }
    }
}