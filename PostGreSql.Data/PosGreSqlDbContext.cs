
using PostGreSql.Model;
using System.Data.Entity;

namespace PostGreSql.Data
{
    public class PosGreSqlDbContext : DbContext
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
    }
}
