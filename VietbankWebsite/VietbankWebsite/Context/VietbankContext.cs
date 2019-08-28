using Microsoft.EntityFrameworkCore;
using VietbankWebsite.Entities;
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
        public DbSet<VbCategoryTranslate> VbCategoryTranslates { get; set; }
        public DbSet<CardHome> CardHomes { get; set; }
        public DbSet<CardData> CardDatas { get; set; }
    }
}
