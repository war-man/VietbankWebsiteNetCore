using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietbankWebsite.Entities
{
    [Table("vb_category")]
    public class VbCategory
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string post_template { get; set; }
        public int parent_id { get; set; }
        public int status { get; set; }
        public string template { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string thumbnail { get; set; }
    }
}
