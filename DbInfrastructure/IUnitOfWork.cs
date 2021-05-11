namespace WebApi.DbInfrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
