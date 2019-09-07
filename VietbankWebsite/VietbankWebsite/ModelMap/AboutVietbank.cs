using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;

namespace VietbankWebsite.ModelMap
{
    public class AboutVietbank
    {

    }

    public class RandomNewsVietbank
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string PublishedDate { get; set; }
    }

    public class IntroduceVietbank
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
    }

    public class NewsDetail : IntroduceVietbank
    {
        public string PublishedDate { get; set; }
    }

    public class TopThreeNewsToCate
    {
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime PublishDate { get; set; }
    }

    public class ListNews {
        public IEnumerable<ListNewsItem> ListNewsItems { get; set; }
        public int PageSize { get; set; }
    }

    public class ListNewsItem : TopThreeNewsToCate {
        public string CategoryName { get; set; }
    }

    public class IntroduceDetail
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
    }

    public class LeadershipDetail : IntroduceDetail { }
    public class GetListPageAboutVietbank
    {
        [Key]
        public string page_title { get; set; }
        public string page_excerpt { get; set; }
        public string page_thumbnail { get; set; }
        public string page_url { get; set; }
    }

    public class BankCodeDataTable
    {
        public IEnumerable<VbBankCode> Data { get; set; }
    }
}
