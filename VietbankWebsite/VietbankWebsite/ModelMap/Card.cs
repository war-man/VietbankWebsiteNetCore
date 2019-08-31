using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;

namespace VietbankWebsite.ModelMap
{
    public class CardProductHomeDto
    {
        [Required]
        [DisplayName("SiteMap")]
        public string SiteMap { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("TitleBoxOne")]
        public string TitleBoxOne { get; set; }

        [Required]
        [DisplayName("DescriptionBoxOne")]
        public string DescriptionBoxOne { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string Path { get; set; }

        [Required]
        [DisplayName("TitleBoxTwo")]
        public string TitleBoxTwo { get; set; }

        [Required]
        [DisplayName("DescriptionBoxTwo")]
        public string DescriptionBoxTwo { get; set; }

        [Required]
        [DisplayName("ContentBoxTwo")]
        public string ContentBoxTwo { get; set; }
    }

    public class CardProductHome
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("TitleBoxOne")]
        public string TitleBoxOne { get; set; }

        [Required]
        [DisplayName("DescriptionBoxOne")]
        public string DescriptionBoxOne { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string Path { get; set; }

        [Required]
        [DisplayName("TitleBoxTwo")]
        public string TitleBoxTwo { get; set; }

        [Required]
        [DisplayName("DescriptionBoxTwo")]
        public string DescriptionBoxTwo { get; set; }

        [Required]
        [DisplayName("ContentBoxTwo")]
        public string ContentBoxTwo { get; set; }
    }

    public class CardProductDetailDto
    {
        [Required]
        [DisplayName("SiteMap")]
        public string SiteMap { get; set; }

        public List<CardHomeBoxOne> BoxOne { get; set; }

        public List<CardHomeBoxTwo> BoxTwo { get; set; }

        [Required]
        [DisplayName("Product banner")]
        public string Banner { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("TitleOne BoxOne")]
        public string TitleOneBoxOne { get; set; }

        [Required]
        [DisplayName("TitleTwo BoxOne")]
        public string TitleTwoBoxOne { get; set; }

        [Required]
        [DisplayName("PathBackground BoxOne")]
        public string PathBackgroundBoxOne { get; set; }

        [Required]
        [DisplayName("PathCard BoxOne")]
        public string PathCardBoxOne { get; set; }

        [Required]
        [DisplayName("Content BoxTwo")]
        public string ContentBoxTwo { get; set; }

        [Required]
        [DisplayName("Title BoxThree")]
        public string TitleBoxThree { get; set; }

        [Required]
        [DisplayName("Description BoxThree")]
        public string DescriptionBoxThree { get; set; }

        [Required]
        [DisplayName("PathBackground BoxThree")]
        public string PathBackgroundBoxThree { get; set; }

        [Required]
        [DisplayName("Title BoxFour")]
        public string TitleBoxFour { get; set; }

        [Required]
        [DisplayName("Content BoxFour")]
        public string ContentBoxFour { get; set; }

        [Required]
        [DisplayName("Url Registration")]
        public string UrlRegistration { get; set; }

        [Required]
        [DisplayName("CardName")]
        public string CardName { get; set; }
    }

    public class CardProductDetail
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Product banner")]
        public string Banner { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("TitleOne BoxOne")]
        public string TitleOneBoxOne { get; set; }

        [Required]
        [DisplayName("TitleTwo BoxOne")]
        public string TitleTwoBoxOne { get; set; }

        [Required]
        [DisplayName("PathBackground BoxOne")]
        public string PathBackgroundBoxOne { get; set; }

        [Required]
        [DisplayName("PathCard BoxOne")]
        public string PathCardBoxOne { get; set; }

        [Required]
        [DisplayName("Content BoxTwo")]
        public string ContentBoxTwo { get; set; }

        [Required]
        [DisplayName("TitleOne BoxOne")]
        public string TitleBoxThree { get; set; }

        [Required]
        [DisplayName("TitleTwo BoxOne")]
        public string DescriptionBoxThree { get; set; }

        [Required]
        [DisplayName("PathBackground BoxOne")]
        public string PathBackgroundBoxThree { get; set; }

        [Required]
        [DisplayName("Title BoxFour")]
        public string TitleBoxFour { get; set; }

        [Required]
        [DisplayName("Content BoxFour")]
        public string ContentBoxFour { get; set; }
    }

    public class IncentivesCateOne
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Path banner")]
        public string PathBanner { get; set; }

        [Required]
        [DisplayName("Link banner")]
        public string LinkBanner { get; set; }

        [Required]
        [DisplayName("Path image middle")]
        public string PathImageMid { get; set; }

        [Required]
        [DisplayName("Path image card left")]
        public string PathCardLeft { get; set; }

        [Required]
        [DisplayName("Content card left")]
        public string ContentCardLeft { get; set; }

        [Required]
        [DisplayName("Path image card right")]
        public string PathCardRight { get; set; }

        [Required]
        [DisplayName("Conent card right")]
        public string ContentCardRight { get; set; }
    }

    public class IncentivesCateOneDto
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("SiteMap")]
        public string SiteMap { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Url")]
        public string Url { get; set; }

        [Required]
        [DisplayName("Path banner")]
        public string PathBanner { get; set; }

        [Required]
        [DisplayName("Link banner")]
        public string LinkBanner { get; set; }

        [Required]
        [DisplayName("Path image middle")]
        public string PathImageMid { get; set; }

        [Required]
        [DisplayName("Path image card left")]
        public string PathCardLeft { get; set; }

        [Required]
        [DisplayName("Content card left")]
        public string ContentCardLeft { get; set; }

        [Required]
        [DisplayName("Path image card right")]
        public string PathCardRight { get; set; }

        [Required]
        [DisplayName("Conent card right")]
        public string ContentCardRight { get; set; }

        [DisplayName("Couple Id")]
        public string Couple { get; set; }

        [Required]
        [DisplayName("Status")]
        public bool Status { get; set; }

        [Required]
        [DisplayName("Priority")]
        public int Priority { get; set; }

        [Required]
        [DisplayName("Language")]
        public string Lang { get; set; }
    }

    public class IncentivesCateTwo
    {
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Url")]
        public string Url { get; set; }

        [Required]
        [DisplayName("Path banner")]
        public string PathBanner { get; set; }

        [Required]
        [DisplayName("Link banner")]
        public string LinkBanner { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }


    }

    public class IncentivesCateTwoDto
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("SiteMap")]
        public string SiteMap { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Url")]
        public string Url { get; set; }

        [Required]
        [DisplayName("Path banner")]
        public string PathBanner { get; set; }

        [Required]
        [DisplayName("Link banner")]
        public string LinkBanner { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("List post")]
        public List<IncentivesPostTwo> Post { get; set; }

        public int PageSize { get; set; }
    }

    public class IncentivesPostTwoPagination
    {
        public List<IncentivesPostTwo> Post { get; set; }

        public int PageSize { get; set; }
    }

    public class IncentivesPostTwo
    {

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Path thumbnail")]
        public string PathThumbNail { get; set; }

        [Required]
        [DisplayName("Content")]
        public string Content { get; set; }

        [Required]
        [DisplayName("Url")]
        public string Url { get; set; }

        [Required]
        [DisplayName("Priority")]
        public int Priority { get; set; }

    }

    public class IncentivesPostTwoDto
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("SiteMap")]
        public string SiteMap { get; set; }

        [Required]
        [DisplayName("Path Banner")]
        public string PathBanner { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Url")]
        public string Url { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Path thumbnail")]
        public string PathThumbNail { get; set; }

        [Required]
        [DisplayName("Content")]
        public string Content { get; set; }

        [DisplayName("Couple Id")]
        public string Couple { get; set; }

        [Required]
        [DisplayName("Status")]
        public bool Status { get; set; }

        [Required]
        [DisplayName("Priority")]
        public int Priority { get; set; }

        [Required]
        [DisplayName("Language")]
        public string Lang { get; set; }

        [DisplayName("Belong to category")]
        public string Parent { get; set; }
    }

    public class IncentivesCateThree
    {
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }



        [Required]
        [DisplayName("Path banner")]
        public string PathBanner { get; set; }

        [Required]
        [DisplayName("Link banner")]
        public string LinkBanner { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string PathImage { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }
    }

    public class IncentivesCateThreeDto
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("SiteMap")]
        public string SiteMap { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Url")]
        public string Url { get; set; }

        [Required]
        [DisplayName("Path banner")]
        public string PathBanner { get; set; }

        [Required]
        [DisplayName("Link banner")]
        public string LinkBanner { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string PathImage { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Couple Id")]
        public string Couple { get; set; }

        [Required]
        [DisplayName("Status")]
        public bool Status { get; set; }

        [Required]
        [DisplayName("Priority")]
        public int Priority { get; set; }

        [Required]
        [DisplayName("Language")]
        public string Lang { get; set; }
    }

    public class IncentivesCateThreeField
    {
        public string Name { get; set; }
    }

    public class IncentivesCateThreeFieldView
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class IncentivesCateThreeFieldDto
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Couple Id")]
        public string Couple { get; set; }

        [Required]
        [DisplayName("Status")]
        public bool Status { get; set; }

        [Required]
        [DisplayName("Priority")]
        public int Priority { get; set; }

        [Required]
        [DisplayName("Language")]
        public string Lang { get; set; }

        [Required]
        [DisplayName("Category")]
        public string Parent { get; set; }
    }


    public class IncentivesCateThreeFieldPost
    {
        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Url")]
        public string Url { get; set; }

        [Required]
        [DisplayName("Thumbnail")]
        public string ThumbNail { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }
    }

    public class IncentivesCateThreeFieldPostPageNum
    {
        public int PageNum { get; set; }
        public List<IncentivesCateThreeFieldPost> Post { get; set; }
    }

    public class IncentivesCateThreeFieldPostDto
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Thumbnail")]
        public string ThumbNail { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Couple Id")]
        public string Couple { get; set; }

        [Required]
        [DisplayName("Status")]
        public bool Status { get; set; }

        [Required]
        [DisplayName("Priority")]
        public int Priority { get; set; }

        [Required]
        [DisplayName("Language")]
        public string Lang { get; set; }

        [Required]
        [DisplayName("Parent")]
        public string Parent { get; set; }

        [Required]
        [DisplayName("District")]
        public string District { get; set; }

        [DisplayName("District")]
        public string NameDistrict { get; set; }
    }

    public class CardSupportCategory
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public bool HasChild { get; set; }
        public string Content { get; set; }
    }

    public class CardSupportCategoryDto
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [DisplayName("Url")]
        public string Url { get; set; }

        [DisplayName("Has category child")]
        public bool HasChild { get; set; }

        [DisplayName("Couple Id")]
        public string Couple { get; set; }

        [Required]
        [DisplayName("Status")]
        public bool Status { get; set; }

        [Required]
        [DisplayName("Priority")]
        public int Priority { get; set; }

        [Required]
        [DisplayName("Language")]
        public string Lang { get; set; }
    }

    public class CardSupportPost
    {
        public string Content { get; set; }
    }

    public class CardSupportBanner
    {
        [Required]
        [DisplayName("Path banner")]
        public string Path { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }
    }

    public class CardSupportPostView
    {
        public string Path { get; set; }
        public string TitleBanner { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string SiteMap { get; set; }
        public bool HasChild { get; set; }
        public List<SupportCategory> Category { get; set; }
    }

    public class CardSupportPostDto
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [DisplayName("Url")]
        public string Url { get; set; }

        public string Content { get; set; }

        [DisplayName("Couple Id")]
        public string Couple { get; set; }

        [Required]
        [DisplayName("Status")]
        public bool Status { get; set; }

        [Required]
        [DisplayName("Priority")]
        public int Priority { get; set; }

        [Required]
        [DisplayName("Language")]
        public string Lang { get; set; }

        [Required]
        public string Parent { get; set; }
    }

    public class SupportCategory
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public bool HasChild { get; set; }
        public string Content { get; set; }
        public List<SupportCategoryChild> Child { get; set; }
    }

    public class SupportCategoryChild
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
