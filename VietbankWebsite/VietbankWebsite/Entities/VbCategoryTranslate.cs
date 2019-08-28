using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietbankWebsite.Entities
{
    [Table("vb_category_translate")]
    public class VbCategoryTranslate
    {
        [Key]
        public int ID { get; set; }
        public int category_ID { get; set; }
        public string name { get; set; }
        public string language { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public string keyword { get; set; }
    }
}
