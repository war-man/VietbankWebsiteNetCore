using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_bank_code")]
    public class VbBankCode
    {
        [Key]
        public int Id { get; set; }
        public string SwiftCode { get; set; }
        public string BankName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int IsUpdate { get; set; }
        public int IsInsert { get; set; }
        public int IdUpdate { get; set; }
    }
}
