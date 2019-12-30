using System.ComponentModel.DataAnnotations;

namespace VietbankWebsite.ModelMap
{
    public class BillLookUpRequest
    {
        [Required]
        public string BillCode { get; set; }
    }

    public class BillLookUpResponse
    {
        public string GetInvoiceResult { get; set; }
    }

    public class BillLookUpResponsePdf
    {
        public string GetInvoice_PDFResult { get; set; }
    }

    public class BillLookUpResponseXml
    {
        public string GetInvoice_XMLResult { get; set; }
    }

    public class BillLookUpResponseInfo
    {
        public string GetInvoice_InforResult { get; set; }
    }

    public class BillInfo
    {
        public string STT { get; set; }
        public string MauSo { get; set; }
        public string KyHieu { get; set; }
        public string SoHoaDon { get; set; }
        public string NgayPhatHanh { get; set; }
        public string TrangThai { get; set; }
    }

    public class BillLookUpParam
    {
        public string MaTraCuu { get; set; }
    }
}
