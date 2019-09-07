using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;

namespace VietbankWebsite.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly VietbankContext _context;
        public HomeRepository(VietbankContext context)
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

        public async Task<IEnumerable<SearchInfor>> GetSearchInfors(string key)
        {
            var p = new DynamicParameters();
            p.Add("@keyword", convertToUnSign2(key));
            var result = await _context.Database.GetDbConnection().QueryAsync<SearchInfor>("[dbo].[vb_fe_SearchData]", p, null, null, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string convertToUnSign2(string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD)).Replace(" ", "-").ToLower();
        }
    }

    public interface IHomeRepository
    {
        Task<IEnumerable<VbBanner>> GetBanner(string lang);
        Task<IEnumerable<SearchInfor>> GetSearchInfors(string key);
    }
}
