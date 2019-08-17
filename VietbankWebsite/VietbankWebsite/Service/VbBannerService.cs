using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class VbBannerService : IVbBannerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public VbBannerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<VbBanner>> GetBanner(string lang)
        {
            return await _unitOfWork.VbBannerRepository.GetBanner(lang);
        }
    }

    public interface IVbBannerService
    {
        Task<IEnumerable<VbBanner>> GetBanner(string lang);
    }
}
