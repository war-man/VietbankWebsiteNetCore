using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.Models
{
    public class EmailSender
    {
        public string DomainMail { get; set; }
        public int PortMail { get; set; }
        public string MailFrom { get; set; }
        public string PassMailFrom { get; set; }
        public string CallCenter { get; set; }
    }
}
