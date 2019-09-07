using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class HomeService : IHomeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<VbBanner>> GetBanner(string lang)
        {
            return await _unitOfWork.HomeRepository.GetBanner(lang);
        }

        public async Task<IEnumerable<SearchInfor>> GetSearchInfors(string key)
        {
            return await _unitOfWork.HomeRepository.GetSearchInfors(key);
        }
    }

    public interface IHomeService
    {
        Task<IEnumerable<VbBanner>> GetBanner(string lang);
        Task<IEnumerable<SearchInfor>> GetSearchInfors(string key);
    }
}
