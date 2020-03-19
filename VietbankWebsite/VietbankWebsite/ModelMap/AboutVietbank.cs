using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Image { get; set; }
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
        public int PostId { get; set; }
        public string PublishedDate { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string FeatureImage { get; set; }
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
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string FeatureImage { get; set; }
    }

    public class LeadershipDetail : IntroduceDetail {
        public int IdPost { get; set; }
    }
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

    [Table("vb_contact",Schema = "dbo")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên!")]
        public string FullName { get; set; }
        public string Phone { get; set; }
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ!")]
        public string Address { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ngành nghề của bạn!")]
        public string Career { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung cần hỗ trợ!")]
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
