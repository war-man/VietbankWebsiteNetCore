using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.ModelMap
{
    public class MailSenderModel
    {
    }

    public class ContactResponseToUser
    {
        public string Message { get; set; }
    }

    public class ContactResponseToCallCenter
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Work { get; set; }
        public string Message { get; set; }
    }
}
