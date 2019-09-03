using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_page_category")]
    public class VbPageCategory
    {
        [Key]
        public int ID { get; set; }
        public int page_ID { get; set; }
        public int category_ID { get; set; }
    }
}
