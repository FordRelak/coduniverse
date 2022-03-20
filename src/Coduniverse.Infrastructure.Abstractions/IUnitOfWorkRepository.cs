using Coduniverse.Domain;

namespace Coduniverse.Infrastructure.Abstractions
{
    public interface IUnitOfWorkRepository
    {
        IGenericRepository<SpaceObject> SpaceObject { get; }
        IGenericRepository<StarSystem> StarSystem { get; }

        Task BeginTransaction();

        Task CommitTransaction();

        Task RollbackTransaction();
    }
}