using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductDetail> GetProductDetail(string aliasCate, string aliastFullCate, string aliasProduct, string lang)
        {
            return await _unitOfWork.ProductRepository.GetProductDetail(aliasCate,aliastFullCate,aliasProduct,lang);
        }

        public async Task<CategoryProduct> ListCategoryProducts(int idCate, string aliasCate, string lang)
        {
            return await _unitOfWork.ProductRepository.ListCategoryProducts(idCate,aliasCate,lang);
        }

        public async Task<CategoryProduct> ListCategoryProducts(int parentId, string aliasSubCate, string aliasCate, string lang)
        {
            return await _unitOfWork.ProductRepository.ListCategoryProducts(parentId,aliasSubCate, aliasCate, lang);
        }

        public async Task<ProductShort> ListProductShort(int parentId,string aliasCate, string aliasFullCate, string lang, int page, int pageSize)
        {
            return await _unitOfWork.ProductRepository.ListProductShort(parentId,aliasCate, aliasFullCate, lang, page, pageSize);
        }
    }

    public interface IProductService
    {
        Task<CategoryProduct> ListCategoryProducts(int idCate, string aliasCate, string lang);
        Task<CategoryProduct> ListCategoryProducts(int parentId, string aliasSubCate, string aliasCate, string lang);
        Task<ProductShort> ListProductShort(int parentId,string aliasCate, string aliasFullCate, string lang, int page, int pageSize);
        Task<ProductDetail> GetProductDetail(string aliasCate, string aliastFullCate, string aliasProduct, string lang);
    }
}
