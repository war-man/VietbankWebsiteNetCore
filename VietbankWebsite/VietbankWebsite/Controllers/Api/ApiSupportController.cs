using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiSupportController : ControllerBase
    {
        private readonly ISupportService _supportService;
        private readonly IStringLocalizer<ApiSupportController> _localizer;
        public ApiSupportController(ISupportService supportService, IStringLocalizer<ApiSupportController> localizer)
        {
            _supportService = supportService;
            _localizer = localizer;
        }

        [HttpGet("getcurrency")]
        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            return await _supportService.GetCurrencies();
        }

        [HttpGet("getcountupdatecurrency")]
        public async Task<int> GetCountUpdateCurrency()
        {
            return await _supportService.GetCountUpdateCurrency();
        }

        [HttpGet("getcountupdatecurrencywheredate")]
        public async Task<int> GetCountUpdateCurrency(string date)
        {
            return await _supportService.GetCountUpdateCurrencyWhereDate(date);
        }

        [HttpGet("getfiltercurrency")]
        public async Task<IEnumerable<Currency>> GetFilterCurrency(string date,int counttime)
        {
            return await _supportService.GetFilterCurrencies(date,counttime);
        }

        [HttpGet("getfiltercurrencychard")]
        public async Task<IEnumerable<CurencyChart>> GetFilterCurrency(string fromDate, string toDate, string currency1, string currency2)
        {
            return await _supportService.GetCurrencyChart(fromDate,toDate,currency1,currency2);
        }

        [HttpGet("getcurrencyconvert")]
        public async Task<IEnumerable<CurencyConvert>> GetCurrencyConvert(string effCode, string currency)
        {
            return await _supportService.GetCurencyConverts(effCode,currency);
        }

        [HttpGet("getlastdateupdate")]
        public async Task<string> GetLastDateUpdate()
        {
            return $"{_localizer["LastUpdateCurrency"]} {await _supportService.GetLastDateUpdate()}";
        }

        [HttpGet("getguaranteeletter")]
        public async Task<string> GetGuaranteeLetter(string acctNbr, string seriesNo)
        {
            return GenerateTableGuaranteeLetter(await _supportService.GetGuaranteeLetter(acctNbr,seriesNo));
        }

        private string GenerateTableGuaranteeLetter(ThuBaoLanhModel thuBaoLanh)
        {
            thuBaoLanh.ISVALID = (thuBaoLanh.CURRACCTSTATCD == "ACT" && (thuBaoLanh.DENNGAY.AddDays(1) > DateTime.Now)) ? _localizer["ThuBaoLanhActivedResult"] : _localizer["ThuBaoLanhExpriedResult"];
            thuBaoLanh.FILESCANURL = string.IsNullOrEmpty(thuBaoLanh.FILESCAN) ? "" : $"<a href='http://www.vietBank.com.vn/uploadFolder/file/scan/{thuBaoLanh.FILESCAN}' target='_blank'>{_localizer["ThuBaoLanhViewLetter"]}</a>";
            string guaranteeLetter = $"<table class='table table-hover' style='padding-bottom: 14px;'>"+
                    $"<thead><tr><th colspan='3'>{_localizer["ThuBaoLanhName"]}</th></tr></thead>"+
                    "<tbody>"+
                        $"<tr><td>{_localizer["ThuBaoLanhSTK"]}</td><td>{thuBaoLanh.ACCTNBR}</td></tr>"+
                        $"<tr><td>{_localizer["ThuBaoLanhSeri"]}</td><td>{thuBaoLanh.SERIES}</td></tr>"+
                        $"<tr><td>{_localizer["ThuBaoLanhPublish"]}</td><td>{thuBaoLanh.DATE_EFF}</td></tr>" +
                        $"<tr><td>{_localizer["ThuBaoLanhValue"]}</td><td>{thuBaoLanh.CURRENTBALANCE} VND</td></tr>"+
                        $"<tr><td>{_localizer["ThuBaoLanhCompany"]}</td><td>{thuBaoLanh.HOTEN}</td></tr>" +
                        $"<tr><td>{_localizer["ThuBaoLanhActive"]}</td><td>{thuBaoLanh.ISVALID}</td></tr>"+
                        $"<tr><td>{_localizer["ThuBaoLanhContent"]}</td><td>{thuBaoLanh.FILESCANURL}</td></tr>"+
                    "</tbody>"+
                "</table>";
            return guaranteeLetter;
        }

    }
}