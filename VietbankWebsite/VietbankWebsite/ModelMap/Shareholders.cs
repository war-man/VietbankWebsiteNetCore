using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.ModelMap
{
    public class ShareholderCategory
    {
        public ShareholderInfo ShareholderInfo { get; set; }
        public IEnumerable<ShareholderItem> shareholderItems { get; set; }
    }

    public class ShareholderInfo
    {
        public string Title { get; set; }
        public string Thumbnail { get; set; }
    }

    public class ShareholderItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Thumbnail { get; set; }
    }

    public class ShareholderDetail
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string Content { get; set; }
    }
}
