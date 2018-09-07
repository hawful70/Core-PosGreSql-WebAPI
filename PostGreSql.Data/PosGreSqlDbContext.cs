
using Microsoft.AspNet.Identity.EntityFramework;
using PostGreSql.Model;
using System.Data.Entity;

namespace PostGreSql.Data
{
    public class PosGreSqlDbContext : IdentityDbContext<AppUser>
    {
        public PosGreSqlDbContext() : base("PosGreSqlDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Tag> Tags { set; get; }

        public DbSet<Error> Errors { set; get; }

        public static PosGreSqlDbContext Create()
        {
            return new PosGreSqlDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasKey<string>(r => r.Id).ToTable("AppRoles");
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("AppUserRoles");
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("AppUserLogins");
            builder.Entity<IdentityUserClaim>().HasKey(i => i.UserId).ToTable("AppUserClaims");
        }
    }
}
