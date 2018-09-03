using PostGreSql.Data;
using System;

namespace CorePosGreSqlWebAPI.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PosGreSqlDbContext Init();
    }
}