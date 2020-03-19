using Microsoft.EntityFrameworkCore;
using VietbankWebsite.Entities;
using VietbankWebsite.Entities.Analytic;
using VietbankWebsite.ModelMap;

namespace VietbankWebsite.Context
{
    public class VietbankContext : DbContext
    {
        public VietbankContext(DbContextOptions<VietbankContext> options)
            : base(options)
        {
        }

        public DbSet<VbBanner> VbBanners { get; set; }
        public DbSet<VbMapUrl> VbMapUrls { get; set; }
        public DbSet<VbPostTranslate> VbPostTranslates { get; set; }
        public DbSet<VbPosts> VbPosts { get; set; }
        public DbSet<VbCategory> VbCategories { get; set; }
        public DbSet<VbPostCategory> VbPostCategories { get; set; }
        public DbSet<VbPageCategory> VbPageCategories { get; set; }
        public DbSet<VbCategoryTranslate> VbCategoryTranslates { get; set; }
        public DbSet<CardHome> CardHomes { get; set; }
        public DbSet<CardData> CardDatas { get; set; }
        public DbSet<VbCareerList> VbCareerLists { get; set; }
        public DbSet<VbCareerCity> VbCareerCities { get; set; }
        public DbSet<VbCareerJob> VbCareerJobs { get; set; }
        public DbSet<VbCareerJobDetail> VbCareerJobDetails { get; set; }
        public DbSet<VbMapProvince> VbMapProvinces { get; set; }
        public DbSet<VbMapDistrict> VbMapDistricts { get; set; }
        public DbSet<VbTransagencyMap> VbTransagencyMaps { get; set; }
        public DbSet<VbBankCode> VbBankCodes { get; set; }
        public DbSet<VbPostSeo> VbPostSeo { get; set; }
        public DbSet<RequestLogs> RequestLogs { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<VbFeedBack> VbFeedBacks { get; set; }
    }
}
