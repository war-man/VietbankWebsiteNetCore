using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_career_job_details")]
    public class VbCareerJobDetail
    {
        [Key]
        public int Id { get; set; }
        public int Job_Id { get; set; }
        public string JobDetails { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Language { get; set; }
        public string JobTitle { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [Column("job_hist")]
        public string JobHist { get; set; }
    }
}
