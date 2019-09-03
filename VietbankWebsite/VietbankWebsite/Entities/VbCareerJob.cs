using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_career_job")]
    public class VbCareerJob
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string CityID { get; set; }
        public string CareerID { get; set; }
        public bool Hot { get; set; }
        [Column("status")]
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Language { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActived { get; set; }
    }

    public class CareerJobList
    {
        public string JobTitle { get; set; }
        public string JobMajor { get; set; }
        public string JobCity { get; set; }
        public string CreatedDate { get; set; }
        public string Url { get; set; }
        public bool IsHot { get; set; }
    }
}
