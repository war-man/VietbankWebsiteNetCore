using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.Entities;

namespace VietbankWebsite.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly VietbankContext _context;
        public ProductRepository(VietbankContext context)
        {
            _context = context;
        }

        public async Task<ProductDetail> GetProductDetail(string aliasCate, string aliastFullCate, string aliasProduct, string lang)
        {
            var productDetail = await (from a in _context.VbPosts
                                join b in _context.VbPostTranslates on a.Id equals b.post_ID
                                join c in _context.VbPostCategories on a.Id equals c.post_ID
                                join d in _context.VbCategoryTranslates on c.category_ID equals d.category_ID
                                where b.post_url.Equals(aliasProduct)
                                where d.slug.Equals(aliasCate)
                                where b.language.Equals(lang)
                                where d.language.Equals(lang)
                                where a.post_status.Equals(4)
                                select new ProductDetail()
                                {
                                    Id = b.ID,
                                    PostId = b.post_ID,
                                    Title = b.post_title,
                                    Thumbnail = a.post_thumbnail ?? "/img/banner_page/vietbank-bg.jpg",
                                    Content = b.post_content,
                                    CategoryName = d.name,
                                    CategoryUrl = $"{aliastFullCate}/{aliasCate}",
                                    Description = b.post_excerpt,
                                    Url = $"{aliastFullCate}/{b.post_url}"
                                }).SingleOrDefaultAsync();
            var vbPostSeo = await _context.VbPostSeo.Where(x => x.IdPost.Equals(productDetail.PostId)).SingleOrDefaultAsync();
            if (vbPostSeo != null)
            {
                productDetail.MetaTitle = vbPostSeo.MetaTitle ?? "";
                productDetail.MetaDescription = vbPostSeo.MetaDescription ?? "";

            }
            else
            {
                productDetail.MetaTitle = "";
                productDetail.MetaDescription = "";
            }
            productDetail.FeatureImage = productDetail.Thumbnail;
            return productDetail;
        }

        public async Task<CategoryProduct> ListCategoryProducts(int idCate, string aliasCate, string lang)
        {
            var result = await (from c in _context.VbCategories
                                join d in _context.VbCategoryTranslates on c.ID equals d.category_ID
                                where c.ID.Equals(idCate)
                                where d.language.Equals(lang)
                                select new CategoryProduct()
                                {
                                    Title = d.name,
                                    Description = d.description,
                                    Thumbnail = c.thumbnail ?? "/img/banner_page/vietbank-bg.jpg"
                                }).FirstOrDefaultAsync();
            List<ListCategoryProduct> lstResult = new List<ListCategoryProduct>();
            var lstCateProduct = await (from a in _context.VbCategories
                                        join b in _context.VbCategoryTranslates on a.ID equals b.category_ID
                                 where a.parent_id.Equals(idCate)
                                 where b.language.Equals(lang)
                                 select new CategoryDetailShort() {
                                     Id = a.ID,
                                     Title = b.name,
                                     Url = $"{aliasCate}/{b.slug}",
                                     Thumbnail = a.thumbnail
                                 }).ToListAsync();
            foreach (var item in lstCateProduct)
            {
                var itemResult = new ListCategoryProduct()
                {
                    CategoryDetailShort = item,
                    CategoryProductShorts = await CategoryProductShorts(item.Id, item.Url, lang)
                };

                lstResult.Add(itemResult);
            }
            result.ListCategoryProduct = lstResult;
            return result;
        }

        public async Task<CategoryProduct> ListCategoryProducts(int parentId, string aliasSubCate, string aliasCate, string lang)
        {
            var result = await(from c in _context.VbCategories
                               join d in _context.VbCategoryTranslates on c.ID equals d.category_ID
                               where c.parent_id.Equals(parentId)
                               where d.slug.Equals(aliasSubCate)
                               where d.language.Equals(lang)
                               select new CategoryProduct()
                               {
                                   Title = d.name,
                                   Description = d.description,
                                   Thumbnail = c.image ?? "/img/banner_page/vietbank-bg.jpg",
                                   ParentId = c.parent_id
                               }).FirstOrDefaultAsync();
            List<ListCategoryProduct> lstResult = new List<ListCategoryProduct>();
            var lstCateProduct = await(from a in _context.VbCategories
                                       join b in _context.VbCategoryTranslates on a.ID equals b.category_ID
                                       where a.parent_id.Equals(parentId)
                                       where b.language.Equals(lang)
                                       select new CategoryDetailShort()
                                       {
                                           Id = a.ID,
                                           Title = b.name,
                                           Url = $"{aliasCate}/{b.slug}",
                                           Thumbnail = a.thumbnail
                                       }).ToListAsync();
            foreach (var item in lstCateProduct)
            {
                var itemResult = new ListCategoryProduct()
                {
                    CategoryDetailShort = item
                };

                lstResult.Add(itemResult);
            }
            result.ListCategoryProduct = lstResult;
            return result;
        }

        public async Task<ProductShort> ListProductShort(int parentId,string aliasCate, string aliasFullCate, string lang, int page, int pageSize)
        {
            var lstProduct = await (from a in _context.VbCategoryTranslates
                             join b in _context.VbPostCategories on a.category_ID equals b.category_ID
                             join c in _context.VbPostTranslates on b.post_ID equals c.post_ID
                             join d in _context.VbPosts on c.post_ID equals d.Id
                             join e in _context.VbCategories on a.category_ID equals e.ID
                             where e.parent_id.Equals(parentId)
                             where a.slug.Equals(aliasCate)
                             where a.language.Equals(lang)
                             where c.language.Equals(lang)
                             where d.post_status.Equals(4)
                             orderby c.ID descending
                             select new ListProductShort()
                             {
                                 Id = c.ID,
                                 Title = c.post_title,
                                 Description = c.post_excerpt,
                                 Thumbnail = d.post_thumbnail,
                                 Url = $"{aliasFullCate}/{c.post_url}"
                             }).Skip(pageSize * page).Take(pageSize).ToListAsync();
            var toalProduct = from a in _context.VbCategoryTranslates
                             join b in _context.VbPostCategories on a.category_ID equals b.category_ID
                             join c in _context.VbPostTranslates on b.post_ID equals c.post_ID
                             join d in _context.VbPosts on c.post_ID equals d.Id
                             join e in _context.VbCategories on a.category_ID equals e.ID
                             where e.parent_id.Equals(parentId)
                             where a.slug.Equals(aliasCate)
                             where a.language.Equals(lang)
                             where c.language.Equals(lang)
                             where d.post_status.Equals(4)
                             select new ListProductShort()
                             {
                                 Id = c.ID
                             };
            return new ProductShort()
            {
                ListProductShorts = lstProduct,
                PageSize = ComputePagination(await toalProduct.CountAsync(), pageSize)
            };
        }

        public async Task<IEnumerable<PrevAndNextProduct>> NextAndPrevProduct(int idCate, string aliasCate, string lang)
        {
            var p = new DynamicParameters();
            p.Add("@idProduct", idCate);
            p.Add("@fullUrl", aliasCate);
            p.Add("@lang", lang);
            return await _context.Database.GetDbConnection().QueryAsync<PrevAndNextProduct>("[dbo].[vb_fe_GetPrevAndNextProduct]", p, null, null, commandType: CommandType.StoredProcedure);
        }

        private async Task<IEnumerable<CategoryProductShort>> CategoryProductShorts(int idCate, string aliasCate,string lang)
        {
            var lstCategory = (from a in _context.VbPostCategories
                              join b in _context.VbPostTranslates on a.post_ID equals b.post_ID
                              join c in _context.VbPosts on b.post_ID equals c.Id
                              where a.category_ID.Equals(idCate)
                              where b.language.Equals(lang)
                              where c.post_status.Equals(4)
                              orderby b.ID descending
                              select new CategoryProductShort()
                              {
                                  Title = b.post_title,
                                  Url = $"{aliasCate}/{b.post_url}"
                              });
            return await lstCategory.Take(5).ToListAsync();
        }

        private int ComputePagination(int total, int pageSize)
        {
            if (total % pageSize == 0)
            {
                return total / pageSize;
            }
            else
            {
                return (total / pageSize) + 1;
            }
        }
    }

    public interface IProductRepository
    {
        Task<CategoryProduct> ListCategoryProducts(int idCate,string aliasCate,string lang);
        Task<CategoryProduct> ListCategoryProducts(int parentId, string aliasSubCate, string aliasCate, string lang);
        Task<ProductShort> ListProductShort(int parentId,string aliasCate, string aliasFullCate, string lang, int page, int pageSize);
        Task<ProductDetail> GetProductDetail(string aliasCate,string aliastFullCate,string aliasProduct,string lang);
        Task<IEnumerable<PrevAndNextProduct>> NextAndPrevProduct(int idCate, string aliasCate, string lang);
    }
}
