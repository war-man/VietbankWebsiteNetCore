using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using VietbankWebsite.Entities;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiEnterpriseController : BaseApiController
    {
        private readonly IProductService _productService;
        private readonly IStringLocalizer<ApiEnterpriseController> _localizer;
        public ApiEnterpriseController(IProductService productService, IStringLocalizer<ApiEnterpriseController> localizer)
        {
            _productService = productService;
            _localizer = localizer;
        }

        [HttpGet("listproducttocategory/{alias}/{page}/{pageSize}")]
        public async Task<ProductShort> ListProductToCategory(string alias, int page, int pageSize)
        {
            return await _productService.ListProductShort(26, alias, $"{_localizer["ProductUrl"]}/{alias}", GetLangCurrent(), page, pageSize);
        }
    }
}