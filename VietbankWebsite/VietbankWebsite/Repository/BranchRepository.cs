using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.Entities;

namespace VietbankWebsite.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private readonly VietbankContext _context;
        public BranchRepository(VietbankContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VbTransagencyMap>> FilterTransagencyMap(string province, string district)
        {
            return await _context.VbTransagencyMaps
                .Where(x => x.City.Equals(province))
                .Where(x => x.Dist.Equals(district))
                .ToListAsync();
        }

        public async Task<IEnumerable<VbTransagencyMap>> GetAllTransagencyMap()
        {
            return await _context.VbTransagencyMaps.ToListAsync();
        }

        public async Task<IEnumerable<VbMapDistrict>> GetMapDistricts(string province)
        {
            return await _context.VbMapDistricts.Where(x => x.ProvinceId.Equals(province)).ToListAsync();
        }

        public async Task<IEnumerable<VbMapProvince>> GetVbMapProvinces()
        {
            return await _context.VbMapProvinces.ToListAsync();
        }
    }

    public interface IBranchRepository
    {
        Task<IEnumerable<VbMapProvince>> GetVbMapProvinces();
        Task<IEnumerable<VbMapDistrict>> GetMapDistricts(string province);
        Task<IEnumerable<VbTransagencyMap>> GetAllTransagencyMap();
        Task<IEnumerable<VbTransagencyMap>> FilterTransagencyMap(string province,string district);
    }
}
