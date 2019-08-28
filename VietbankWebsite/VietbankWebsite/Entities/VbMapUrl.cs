using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities
{
    [Table("vb_map_url")]
    public class VbMapUrl
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }

        [Column("id_map")]
        public int IdMap { get; set; }

        [Column("url_map")]
        public string UrlMap { get; set; }

        [Column("type_map")]
        public string TypeMap { get; set; }

        [Column("lang_map")]
        public string LangMap { get; set; }

        [Column("id_category_post")]
        public int IdCategoryPost { get; set; }

        [Column("CardId")]
        public string CardId { get; set; }
    }
}
