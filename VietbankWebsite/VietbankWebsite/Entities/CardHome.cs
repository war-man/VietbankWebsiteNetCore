using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietbankWebsite.Entities
{
    [Table("CardHome")]
    public class CardHome
    {

        [Key]
        public string Id { get; set; }
        public string BoxOne { get; set; }
        public string BoxTwo { get; set; }
        public string BoxThree { get; set; }
        public string BoxFour { get; set; }
        public string BoxFive { get; set; }
        public string BoxSix { get; set; }
        public string BoxSeven { get; set; }
    }

    public class CardHomeTemplate
    {
        public List<CardHomeBoxOne> BoxOne { get; set; }
        public List<CardHomeBoxTwo> BoxTwo { get; set; }
        public CardHomeBoxThree BoxThree { get; set; }
        public CardHomeBoxFour BoxFour { get; set; }
        public CardHomeBoxFive BoxFive { get; set; }
        public CardHomeBoxSix BoxSix { get; set; }
        public CardHomeBoxSeven BoxSeven { get; set; }
    }

    public class CardHomeBoxOne
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Link banner")]
        public string Url { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string Path { get; set; }

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

    public class CardHomeBoxTwo
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string UrlImage { get; set; }

        [Required]
        [DisplayName("TitleBoxOne card")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Link title")]
        public string UrlTitle { get; set; }

        [Required]
        [DisplayName("DescriptionBoxOne")]
        public string Description { get; set; }

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

    public class CardHomeBoxThree
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("TitleBoxOne large")]
        public string TitleOne { get; set; }

        [Required]
        [DisplayName("TitleBoxOne small")]
        public string TitleTwo { get; set; }

        [Required]
        [DisplayName("DescriptionBoxOne")]
        public string Description { get; set; }

        [Required]
        [DisplayName("List image")]
        public string Url { get; set; }

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

    public class CardHomeBoxFour
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("TitleBoxOne large")]
        public string TitleOne { get; set; }

        [Required]
        [DisplayName("TitleBoxOne small")]
        public string TitleTwo { get; set; }

        [Required]
        [DisplayName("DescriptionBoxOne")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string Url { get; set; }

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

    public class CardHomeBoxFive
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("TitleBoxOne large")]
        public string TitleOne { get; set; }

        [Required]
        [DisplayName("TitleBoxOne small")]
        public string TitleTwo { get; set; }

        [Required]
        [DisplayName("DescriptionBoxOne")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string Url { get; set; }

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

    public class CardHomeBoxSix
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("TitleBoxOne large")]
        public string TitleOne { get; set; }

        [Required]
        [DisplayName("TitleBoxOne small")]
        public string TitleTwo { get; set; }

        [Required]
        [DisplayName("DescriptionBoxOne")]
        public string Description { get; set; }

        [Required]
        [DisplayName("List box")]
        public string ListBox { get; set; }

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

    public class CardHomeBoxSeven
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("TitleBoxOne large")]
        public string TitleOne { get; set; }

        [Required]
        [DisplayName("TitleBoxOne small")]
        public string TitleTwo { get; set; }

        [Required]
        [DisplayName("DescriptionBoxOne")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Path image")]
        public string Url { get; set; }

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
}
