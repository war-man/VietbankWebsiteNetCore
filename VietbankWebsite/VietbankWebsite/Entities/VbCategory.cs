using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace VietbankWebsite.Entities
{
    [Table("vb_category")]
    public class VbCategory
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string post_template { get; set; }
        public int parent_id { get; set; }
        public int status { get; set; }
        public string template { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string thumbnail { get; set; }
    }

    public class CategoryProduct
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public int ParentId { get; set; }
        public IEnumerable<ListCategoryProduct> ListCategoryProduct { get; set; }
    }

    public class ListCategoryProduct
    {
        public CategoryDetailShort CategoryDetailShort { get; set; }
        public IEnumerable<CategoryProductShort> CategoryProductShorts { get; set; }
    }

    public class CategoryDetailShort
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Url { get; set; }
    }

    public class ProductShort : CategoryDetailShort
    {
        public IEnumerable<ListProductShort> ListProductShorts { get; set; }
        public int PageSize { get; set; }
    }

    public class ListProductShort: CategoryDetailShort {
        public string Description { get; set; }
    }

    public class ProductDetail : CategoryDetailShort
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryUrl { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string FeatureImage { get; set; }
        public string BannerProduct { get; set; }
        public IEnumerable<PrevAndNextProduct> PrevNextProduct { get; set; }
    }

    public class CategoryProductShort
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }

    public class PrevAndNextProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
