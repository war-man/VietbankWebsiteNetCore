using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietbankWebsite.Entities
{
    [Table("vb_posts")]
    public class VbPosts
    {
        [Key]
        public int Id { get; set; }
        public string post_title { get; set; }
        public int post_status { get; set; }
        public string post_thumbnail { get; set; }
        public string ping_status { get; set; }
        public string guid { get; set; }
        public int to_ping { get; set; }
        public DateTime post_date { get; set; }
    }
}
