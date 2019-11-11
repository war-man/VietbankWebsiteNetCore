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
        public async Task<IEnumerable<VbBanner>> GetBanner(string lang, string device)
        {
            return await _unitOfWork.HomeRepository.GetBanner(lang,device);
        }

        public async Task<IEnumerable<BannerIndexView>> GetBoxContainer(string type, string lang)
        {
            return await _unitOfWork.HomeRepository.GetBoxContainer(type,lang);
        }

        public IEnumerable<SPVbFormatSiteMap> GetFormatSiteMap()
        {
            return _unitOfWork.HomeRepository.GetFormatSiteMap();
        }

        public async Task<IEnumerable<SearchInfor>> GetSearchInfors(string key)
        {
            return await _unitOfWork.HomeRepository.GetSearchInfors(key);
        }

        public async Task<IEnumerable<VbMapUrl>> GetVbMapUrl()
        {
            return await _unitOfWork.HomeRepository.GetVbMapUrl();
        }
    }

    public interface IHomeService
    {
        Task<IEnumerable<VbBanner>> GetBanner(string lang, string device);
        Task<IEnumerable<SearchInfor>> GetSearchInfors(string key);
        Task<IEnumerable<BannerIndexView>> GetBoxContainer(string type, string lang);
        Task<IEnumerable<VbMapUrl>> GetVbMapUrl();
        IEnumerable<SPVbFormatSiteMap> GetFormatSiteMap();
    }
}
