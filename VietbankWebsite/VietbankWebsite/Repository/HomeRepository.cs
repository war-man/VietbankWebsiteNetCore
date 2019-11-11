using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
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
        public async Task<IEnumerable<VbBanner>> GetBanner(string lang, string device)
        {
            var banner = from a in _context.VbBanners
                         where a.Status.Equals(1)
                         where a.Lang.Equals(lang)
                         where a.Type.Equals("top")
                         orderby a.Prioritize
                         select a;
            var bannerList = await banner.ToListAsync();
            return FormatBanner(bannerList,device);
        }

        private IEnumerable<VbBanner> FormatBanner(IEnumerable<VbBanner> banner,string device)
        {
            switch (device)
            {
                case "Mobile":
                    var bannerMobile = banner.Where(x => x.ImgThree?.Length > 0).ToList();
                    if (bannerMobile.Any())
                    {
                        foreach (var item in bannerMobile)
                        {
                            item.Image = item.ImgThree;
                        }
                        return bannerMobile;
                    }
                    return new List<VbBanner>();
                    
                case "Tablet":
                    var bannerTable = banner.Where(x => x.ImgTwo?.Length > 0).ToList();
                    if (bannerTable.Any())
                    {
                        foreach (var item in bannerTable)
                        {
                            item.Image = item.ImgTwo;
                        }
                        return bannerTable;
                    }
                    return new List<VbBanner>();
                default:
                    return banner;
            }
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

        public async Task<IEnumerable<BannerIndexView>> GetBoxContainer(string type, string lang)
        {
            var p = new DynamicParameters();
            p.Add("@type", type);
            p.Add("@lang", lang);
            var boxContainer = await _context.Database.GetDbConnection().QueryAsync<BannerIndexView>("[dbo].[vb_fe_get_filter_banner_lang]", p, null, null, commandType: CommandType.StoredProcedure);
            return boxContainer;
        }

        public async Task<IEnumerable<VbMapUrl>> GetVbMapUrl()
        {
            return await _context.VbMapUrls.Where(x=>x.UrlMap.Length > 0).OrderByDescending(x=>x.Id).ToArrayAsync();
        }

        public IEnumerable<SPVbFormatSiteMap> GetFormatSiteMap()
        {
            var result = _context.Database.GetDbConnection().Query<SPVbFormatSiteMap>("[dbo].[vb_fe_formatUrlSitemap]", commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
    }

    public interface IHomeRepository
    {
        Task<IEnumerable<VbBanner>> GetBanner(string lang,string device);
        Task<IEnumerable<SearchInfor>> GetSearchInfors(string key);
        Task<IEnumerable<BannerIndexView>> GetBoxContainer(string type,string lang);
        Task<IEnumerable<VbMapUrl>> GetVbMapUrl();
        IEnumerable<SPVbFormatSiteMap> GetFormatSiteMap();
    }
}
