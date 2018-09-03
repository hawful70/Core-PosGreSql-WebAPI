using CorePosGreSqlWebAPI.Data.Infrastructure;
using PostGreSql.Model;

namespace CorePosGreSqlWebAPI.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}