using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;

namespace VietbankWebsite.Controllers
{
    [Route("tracuuhoadon")]
    public class TraCuuHoaDonController : Controller
    {
        private readonly RemoteService _remoteService;
        private IRecaptchaService _recaptcha;
        private readonly string _webRootPath;
        public TraCuuHoaDonController(IOptions<RemoteService> remoteService, IRecaptchaService recaptcha, IHostingEnvironment hostingEnvironment)
        {
            _remoteService = remoteService.Value;
            _recaptcha = recaptcha;
            _webRootPath = hostingEnvironment.WebRootPath;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(BillLookUpRequest model)
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
            var resultBillLookUp = await GetRemoteBillLookUp(model.BillCode);
            ViewData["BillResult"] = resultBillLookUp;
            return View(model);
        }



        private async Task<string> GetRemoteBillLookUp(string billCode)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(new BillLookUpParam() { MaTraCuu = billCode }), Encoding.UTF8, "application/json");
                HttpResponseMessage resInfo = await client.PostAsync(_remoteService.BillLookUpInfo, content);
                HttpResponseMessage resXml = await client.PostAsync(_remoteService.BillLookUpXml, content);
                HttpResponseMessage resPdf = await client.PostAsync(_remoteService.BillLookUpPdf, content);
                if (resInfo.IsSuccessStatusCode && resXml.IsSuccessStatusCode && resPdf.IsSuccessStatusCode)
                {
                    var resultInfo = JsonConvert.DeserializeObject<BillLookUpResponseInfo>(await resInfo.Content.ReadAsStringAsync());                    
                    var resultXml = JsonConvert.DeserializeObject<BillLookUpResponseXml>(await resXml.Content.ReadAsStringAsync());
                    var resultPdf = JsonConvert.DeserializeObject<BillLookUpResponsePdf>(await resPdf.Content.ReadAsStringAsync());
                    if (resultInfo.GetInvoice_InforResult.Equals("No data found") || resultPdf.GetInvoice_PDFResult.Equals("No data found") || resultXml.GetInvoice_XMLResult.Equals("No data found"))
                    {
                        return "<strong>No data found</strong>";
                    }
                    string pdfUrl = SaveBase64ToPdf(resultPdf.GetInvoice_PDFResult,billCode);
                    string xmlUrl = SaveStringToXml(resultXml.GetInvoice_XMLResult, billCode);
                    var billInfo = JsonConvert.DeserializeObject<BillInfo>(resultInfo.GetInvoice_InforResult);
                    return $"{GenerateTable(billInfo)}<br/>{GenerateHtml(pdfUrl, xmlUrl)}" ;
                }
                return "<strong>No data found</strong>";
            }
        }

        private string SaveBase64ToPdf(string base64,string billFile)
        {
            string path = Path.Combine(_webRootPath, "billlookup");
            byte[] bytes = Convert.FromBase64String(base64);
            if (System.IO.File.Exists($"{path}/{billFile}.pdf"))
                System.IO.File.Delete($"{path}/{billFile}.pdf");
            FileStream stream = new FileStream($"{path}/{billFile}.pdf", FileMode.CreateNew);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(bytes, 0, bytes.Length);
            writer.Close();
            return $"/billlookup/{billFile}.pdf";
        }

        private string SaveStringToXml(string xml, string billFile)
        {
            string path = Path.Combine(_webRootPath, "billlookup");
            if (System.IO.File.Exists($"{path}/{billFile}.xml"))
                System.IO.File.Delete($"{path}/{billFile}.xml");
            System.IO.File.WriteAllText($"{path}/{billFile}.xml", xml);
            return $"/billlookup/{billFile}.xml";
        }

        private string GenerateTable(BillInfo billInfo)
        {
            var table = $"<table class='table' style='padding-bottom: 14px;'>";
            table += $"<thead><tr>";
            table += $"<th style='text-align: left;'>STT</th>";
            table += $"<th style='text-align: left;'>Mẫu số</th>";
            table += $"<th style='text-align: left;'>Ký hiệu</th>";
            table += $"<th style='text-align: left;'>Số hóa đơn</th>";
            table += $"<th style='text-align: left;'>Ngày phát hành</th>";
            table += $"<th style='text-align: left;'>Trạng thái</th>";
            table += $"</tr></thead>";
            table += $"<tbody style='background-color: white;'><tr>";
            table += $"<th>{billInfo.STT}</th>";
            table += $"<th>{billInfo.MauSo}</th>";
            table += $"<th>{billInfo.KyHieu}</th>";
            table += $"<th>{billInfo.SoHoaDon}</th>";
            table += $"<th>{billInfo.NgayPhatHanh}</th>";
            table += $"<th>{billInfo.TrangThai}</th>";
            table += $"</tr></tbody>";
            table += $"</table>";
            return table;
        }

        private string GenerateHtml(string pdf,string xml)
        {
            var html = $"<a class='btn btn-primary' href='{pdf}' download>Tải file PDF</a> | <a class='btn btn-primary' href='{xml}' download>Tải file XML</a>";
            return html;
        }
    }
}