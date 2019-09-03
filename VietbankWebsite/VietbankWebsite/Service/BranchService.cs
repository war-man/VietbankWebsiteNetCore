using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class BranchService : IBranchService
    {
        private IUnitOfWork _unitOfWork;
        public BranchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<VbTransagencyMap>> FilterTransagencyMap(string province, string district)
        {
            return await _unitOfWork.BranchRepository.FilterTransagencyMap(province,district);
        }

        public async Task<IEnumerable<VbTransagencyMap>> GetAllTransagencyMap()
        {
            return await _unitOfWork.BranchRepository.GetAllTransagencyMap();
        }

        public async Task<IEnumerable<VbMapDistrict>> GetMapDistricts(string province)
        {
            return await _unitOfWork.BranchRepository.GetMapDistricts(province);
        }

        public async Task<IEnumerable<VbMapProvince>> GetVbMapProvinces()
        {
            return await _unitOfWork.BranchRepository.GetVbMapProvinces();
        }
    }
    public interface IBranchService
    {
        Task<IEnumerable<VbMapProvince>> GetVbMapProvinces();
        Task<IEnumerable<VbMapDistrict>> GetMapDistricts(string province);
        Task<IEnumerable<VbTransagencyMap>> GetAllTransagencyMap();
        Task<IEnumerable<VbTransagencyMap>> FilterTransagencyMap(string province, string district);
    }
}
