using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.ModelMap;

namespace VietbankWebsite.Repository
{
    public class ShareholderRepository : IShareholderRepository
    {
        public readonly VietbankContext _context;
        public ShareholderRepository(VietbankContext context)
        {
            _context = context;
        }
        public async Task<ShareholderCategory> ShareholderCategories(string category, string alias, string lang)
        {
            var listItem = from a in _context.VbCategories
                           join b in _context.VbPostCategories on a.ID equals b.category_ID
                           join c in _context.VbPosts on b.post_ID equals c.Id
                           join d in _context.VbPostTranslates on c.Id equals d.post_ID
                           where a.slug.Equals(alias)
                           where d.language.Equals(lang)
                           select new ShareholderItem()
                           {
                               Title = d.post_title,
                               Description = d.post_excerpt,
                               Thumbnail = c.post_thumbnail,
                               Url = $"{category}/{d.post_url}"
                           };
            var cateInfo = await _context.VbCategories.Where(x => x.slug.Equals(alias)).FirstOrDefaultAsync();
            return new ShareholderCategory()
            {
                ShareholderInfo = new ShareholderInfo()
                {
                    Title = cateInfo.name,
                    Thumbnail = cateInfo.thumbnail??"/Content/user/image/banner_page/VietBank-bg.jpg"
                },
                shareholderItems = await listItem.ToListAsync()
            };
        }
    }

    public interface IShareholderRepository
    {
        Task<ShareholderCategory> ShareholderCategories(string category,string alias,string lang);
    }
}
