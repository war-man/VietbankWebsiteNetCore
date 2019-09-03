using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_map_province")]
    public class VbMapProvince
    {
        [Key]
        [Column("provinceid")]
        public string ProvinceId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("type")]
        public string Type { get; set; }
    }
}
