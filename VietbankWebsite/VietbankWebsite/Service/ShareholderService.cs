using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class ShareholderService : IShareholderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShareholderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ShareholderCategory> ShareholderCategories(string category, string alias, string lang)
        {
            return await _unitOfWork.ShareholderRepository.ShareholderCategories(category,alias, lang);
        }
    }

    public interface IShareholderService
    {
        Task<ShareholderCategory> ShareholderCategories(string category, string alias, string lang);
    }
}
