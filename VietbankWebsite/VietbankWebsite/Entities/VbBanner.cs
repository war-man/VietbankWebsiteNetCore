using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietbankWebsite.Entities
{
    [Table("vb_banner")]
    public class VbBanner
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("link")]
        public string Link { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("lang")]
        public string Lang { get; set; }
        [Column("datetime")]
        public DateTime Datetime { get; set; }
        [Column("prioritize")]
        public int Prioritize { get; set; }
        [Column("category")]
        public string Category { get; set; }
    }
}
