using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_map_district")]
    public class VbMapDistrict
    {
        [Key]
        [Column("districtid")]
        public string DistrictId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("location")]
        public string Location { get; set; }
        [Column("provinceid")]
        public string ProvinceId { get; set; }
    }
}
