using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Models.Queue
{
    public class CountRequestQueue
    {
        public string IpRequest { get; set; }
        public string UrlRequest { get; set; }
        public long Time { get; set; }
    }
}
