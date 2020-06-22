using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietbankWebsite.Entities
{
    [Table("vb_feedback")]
    public class VbFeedBack
    {
        [Key]
        public int Id { get; set; }
        public int IdPost { get; set; }
        public string TitlePost { get; set; }
        [Required(ErrorMessage = "Thông tin này cần phải được nhập")]
        public string NameCustomer { get; set; }
        [Required(ErrorMessage = "Thông tin này cần phải được nhập")]
        [EmailAddress]
        public string EmailCustomer { get; set; }
        [Required(ErrorMessage = "Thông tin này cần phải được nhập")]
        public string PhonerCustomer { get; set; }
        public string ContentCustomer { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDone { get; set; }
    }
}
