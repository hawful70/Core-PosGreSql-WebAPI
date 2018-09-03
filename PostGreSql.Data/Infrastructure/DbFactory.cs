using PostGreSql.Data;

namespace CorePosGreSqlWebAPI.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PosGreSqlDbContext dbContext;

        public PosGreSqlDbContext Init()
        {
            return dbContext ?? (dbContext = new PosGreSqlDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}