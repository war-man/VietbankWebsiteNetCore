using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietbankWebsite.Entities
{
    [Table("vb_transagencymap")]
    public class VbTransagencyMap
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int BranchType { get; set; }
        public string BranchCode { get; set; }
        public string TransAgencyName { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Dist { get; set; }
        public string Details { get; set; }
    }
}
