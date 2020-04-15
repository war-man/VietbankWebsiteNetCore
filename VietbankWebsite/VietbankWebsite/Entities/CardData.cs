using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("CardData")]
    public class CardData
    {
        [Key]
        public string Id { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Type { get; set; }

        public bool Status { get; set; }

        public string Lang { get; set; }

        public string Url { get; set; }

        public string Couple { get; set; }

        public int Priority { get; set; }

        public string Parent { get; set; }

        public string SiteMap { get; set; }

        public string Title { get; set; }

        public string District { get; set; }

        public int Approved { get; set; }

        public DateTime CreatedDate { get; set; }
    }

    public class CustomerInfo
    {
        public string HoTen { get; set; }
        public string LoaiGiayTo { get; set; }
        public string SoGiayTo { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string Tinh { get; set; }
        public string IsOnline { get; set; }
        public string BranchId { get; set; }
        public int Status { get; set; }
    }
}
