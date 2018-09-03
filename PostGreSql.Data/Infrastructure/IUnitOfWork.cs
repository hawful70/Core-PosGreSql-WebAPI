namespace CorePosGreSqlWebAPI.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}