using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class VbPostSeoService : IVbPostSeoService
    {
        private IUnitOfWork _unitOfWork;
        public VbPostSeoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<VbPostSeo> FindToPostId(int postId)
        {
            return await _unitOfWork.VbPostSeoRepository.FindToPostId(postId);
        }
    }

    public interface IVbPostSeoService
    {
        Task<VbPostSeo> FindToPostId(int postId);
    }
}
