
using System.Data.Entity;

namespace PostGreSql.Data
{
    public class PosGreSqlDbContext : DbContext
    {
        public PosGreSqlDbContext() : base("PosGreSqlDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    }
}
