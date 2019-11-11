using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Entities.Analytic
{
    [Table("RequestLogs", Schema = "analytic")]
    public class RequestLogs
    {
        [Key]
        public int Id { get; set; }
        public string IpRemote { get; set; }
        public string UrlRequest { get; set; }
        public int Time { get; set; }

        public string Type { get; set; }
        public DateTime Created { get; set; }
    }
}
