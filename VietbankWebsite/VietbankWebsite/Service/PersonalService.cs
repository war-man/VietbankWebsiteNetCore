using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class PersonalService : IPersonalService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonalService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<CategoryProduct> ListCategoryProducts(int idCate, string aliasCate, string lang)
        {
            return await _unitOfWork.PersonalRepository.ListCategoryProducts(idCate,aliasCate,lang);
        }

        public async Task<CategoryProduct> ListCategoryProducts(string aliasSubCate, string aliasCate, string lang)
        {
            return await _unitOfWork.PersonalRepository.ListCategoryProducts(aliasSubCate, aliasCate, lang);
        }

        public async Task<ProductShort> ListProductShort(string aliasCate, string aliasFullCate, string lang, int page, int pageSize)
        {
            return await _unitOfWork.PersonalRepository.ListProductShort(aliasCate, aliasFullCate, lang, page, pageSize);
        }
    }

    public interface IPersonalService
    {
        Task<CategoryProduct> ListCategoryProducts(int idCate, string aliasCate, string lang);
        Task<CategoryProduct> ListCategoryProducts(string aliasSubCate, string aliasCate, string lang);
        Task<ProductShort> ListProductShort(string aliasCate, string aliasFullCate, string lang, int page, int pageSize);
    }
}
