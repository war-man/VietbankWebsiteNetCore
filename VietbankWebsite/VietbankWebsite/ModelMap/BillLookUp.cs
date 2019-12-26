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

    public class BillLookUpParam
    {
        public string MaTraCuu { get; set; }
    }
}
