using System;
using System.Collections.Generic;
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
        [Column("imgTwo")]
        public string ImgTwo { get; set; }
        [Column("imgThree")]
        public string ImgThree { get; set; }
        [Column("imgFour")]
        public string ImgFour { get; set; }

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

    public class BannerIndexView
    {
        public int ID { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string type { get; set; }
        public int status { get; set; }
        public string lang { get; set; }
        public string category { get; set; }
    }

    public class BoxContainerHomePage
    {
        public IEnumerable<VbBanner> Banner { get; set; }
        public IEnumerable<BannerIndexView> Box { get; set; }
        public IEnumerable<BannerIndexView> Between { get; set; }
        public IEnumerable<BannerIndexView> News { get; set; }
    }
}
