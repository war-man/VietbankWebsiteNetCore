using Microsoft.EntityFrameworkCore;
using VietbankWebsite.Entities;

namespace VietbankWebsite.Context
{
    public class VietbankContext : DbContext
    {
        public VietbankContext(DbContextOptions<VietbankContext> options)
            : base(options)
        {
        }

        public DbSet<VbBanner> VbBanners { get; set; }
        public DbSet<VbPostTranslate> VbPostTranslates { get; set; }
        public DbSet<VbPosts> VbPosts { get; set; }
        public DbSet<VbCategory> VbCategories { get; set; }
        public DbSet<VbPostCategory> VbPostCategories { get; set; }

    }
}
