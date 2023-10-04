namespace Infra.Configurations
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();

    }
}