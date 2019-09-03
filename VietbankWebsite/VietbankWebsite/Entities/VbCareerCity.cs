using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_career_city")]
    public class VbCareerCity
    {
        [Key]
        [Column("Id")]
        public int ID { get; set; }
        [Column("vi_CityName")]
        public string ViCityName { get; set; }
        public int Preority { get; set; }
        [Column("en_CityName")]
        public string EnCityName { get; set; }
    }

    public class VbCareerCityView
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }
}
