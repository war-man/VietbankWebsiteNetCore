using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.ModelMap
{
    public class Support
    {
    }

    public class Faqs
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public IEnumerable<FaqsCategory> FaqsCategories { get; set; }
    }

    public class FaqsCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<FaqsItem> FaqsItems { get; set; }
    }

    public class FaqsItem
    {
        public string Answer { get; set; }
        public string Question { get; set; }
    }

    public class InterestRate
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public IEnumerable<InterestRateItem> InterestRateItems { get; set; }
    }

    public class InterestRateItem
    {
        public string Tilte { get; set; }
        public string Content { get; set; }
    }

    public class Form : InterestRate { }

    public class ThuBaoLanhModel
    {
        public bool HasResulted { get; set; }
        public string GuaranteeAcct { get; set; }
        public string GuaranteeCode { get; set; }
        public string CaptchaText { get; set; }

        public DateTime TUNGAY { get; set; }
        public DateTime DENNGAY { get; set; }
        public string CURRACCTSTATCD { get; set; }
        public string HOTEN { get; set; }
        public string CURRENTBALANCE { get; set; }
        public string SERIES { get; set; }
        public DateTime DATELASTMAINT { get; set; }
        public string ACCTNBR { get; set; }
        public string DATE_EFF { get; set; }
        public string STATUS { get; set; }
        public string ISVALID { get; set; }
        public int PRINTED { get; set; }
        public string DIACHI { get; set; }
        public string FILESCAN { get; set; }
        public string FILESCANURL { get; set; }
    }

    public class ThuBaoLanhResponse
    {
        public string resultcode { get; set; }
        public string resultdesc { get; set; }
        public ThuBaoLanhItem tbl { get; set; }
    }

    public class ThuBaoLanhItem
    {
        public string tungay { get; set; }
        public string denngay { get; set; }
        public string status { get; set; }
        public string ten { get; set; }
        public string balance { get; set; }
        public string series { get; set; }
        public string datelastmaint { get; set; }
        public string branchcode { get; set; }
        public string acctnbr { get; set; }
        public string datE_EFF { get; set; }
        public string useraD_KSV { get; set; }
        public string useraD_LCSR { get; set; }
        public string printed { get; set; }
        public string diachi { get; set; }
        public string branchname { get; set; }
        public string filescan { get; set; }

    }

    public class GuaranteelLetter
    {
        [Required(ErrorMessage = "Vui lòng nhập Số tài khoản!")]
        [MaxLength(20,ErrorMessage = "Vượt chiều dài tối đa 20 ký tự")]
        [MinLength(3, ErrorMessage = "Chiều dài tối thiểu 3 ký tự")]
        public string acctNbr { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Số seri thư bảo lãnh!")]
        [MaxLength(20, ErrorMessage = "Vượt chiều dài tối đa 20 ký tự")]
        [MinLength(3, ErrorMessage = "Chiều dài tối thiểu 3 ký tự")]
        public string seriesNo { get; set; }
    }
}
