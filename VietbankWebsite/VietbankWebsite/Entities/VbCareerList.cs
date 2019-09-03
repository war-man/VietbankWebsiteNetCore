using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_career_list")]
    public class VbCareerList
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("vi_CareerName")]
        public string ViCareerName { get; set; }
        [Column("en_CareerName")]
        public string EnCareerName { get; set; }
        public int Preority { get; set; }
        public bool Status { get; set; }
    }

    public class VbCareerListView
    {
        public int Id { get; set; }
        public string CareerName { get; set; }
    }
}
