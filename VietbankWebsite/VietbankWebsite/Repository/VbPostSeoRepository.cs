using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.Entities;

namespace VietbankWebsite.Repository
{
    public class VbPostSeoRepository : IVbPostSeoRepository
    {
        private readonly VietbankContext _context;
        public VbPostSeoRepository(VietbankContext context)
        {
            _context = context;
        }

        public async Task<VbPostSeo> FindToPostId(int postId)
        {
            return await _context.VbPostSeo.Where(x => x.IdPost.Equals(postId)).SingleOrDefaultAsync();
        }
    }

    public interface IVbPostSeoRepository
    {
        Task<VbPostSeo> FindToPostId(int postId);
    }
}
