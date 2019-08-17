using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietbankWebsite.Entities
{
    [Table("vb_posts_translate")]
    public class VbPostTranslate
    {
        [Key]
        public int ID { get; set; }
        public int post_ID { get; set; }
        public string post_content { get; set; }
        public string post_excerpt { get; set; }
        public string post_title { get; set; }
        public string language { get; set; }
        public string post_url { get; set; }
        public string post_content_temp { get; set; }
        public int status { get; set; }
        public string keyword { get; set; }

    }
}
