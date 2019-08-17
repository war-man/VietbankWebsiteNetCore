using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.Entities;

namespace VietbankWebsite.Repository
{
    public class VbBannerRepository : IVbBannerRepository
    {
        private readonly VietbankContext _context;
        public VbBannerRepository(VietbankContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<VbBanner>> GetBanner(string lang)
        {
            var banner = from a in _context.VbBanners
                         where a.Status.Equals(1)
                         where a.Lang.Equals(lang)
                         where a.Type.Equals("top")
                         orderby a.Prioritize
                         select a;
            return await banner.ToListAsync();
        }
    }

    public interface IVbBannerRepository
    {
        Task<IEnumerable<VbBanner>> GetBanner(string lang);
    }
}
