using Coduniverse.Domain;
using Coduniverse.Infrastructure.Abstractions;

namespace Coduniverse.Infrastructure.EF
{
    public class UOWRepository : IUnitOfWorkRepository
    {
        private readonly EfDbContext _context;
        private readonly IGenericRepository<SpaceObject> _spaceObject;
        private readonly IGenericRepository<StarSystem> _starSystem;

        public IGenericRepository<SpaceObject> SpaceObject => _spaceObject;

        public IGenericRepository<StarSystem> StarSystem => _starSystem;

        public UOWRepository(IGenericRepository<StarSystem> starSystem,
                             IGenericRepository<SpaceObject> spaceObject,
                             EfDbContext context)
        {
            _starSystem = starSystem;
            _spaceObject = spaceObject;
            _context = context;
        }

        #region Transactions

        public async Task BeginTransaction()
        {
            if(_context.Database.CurrentTransaction is null)
                await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransaction()
        {
            if(_context.Database.CurrentTransaction is not null)
                await _context.Database.CommitTransactionAsync();
        }

        public async Task RollbackTransaction()
        {
            if(_context.Database.CurrentTransaction is not null)
                await _context.Database.RollbackTransactionAsync();
        }

        #endregion Transactions
    }
}