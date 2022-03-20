using Coduniverse.Application.Abstractions.Models;
using Coduniverse.Domain;
using System.Linq.Expressions;

namespace Coduniverse.Application.Abstractions
{
    public interface IUnitOfWorkService
    {
        Task<SpaceObject> CreateSpaceObject(SpaceObjectDTO spaceObject);
        Task DeleteSpaceObjectAsync(Guid id);
        Task<IEnumerable<SpaceObject>> GetAllSpaceObjectAsync(bool includeStarSystem = true);

        Task<IEnumerable<StarSystem>> GetAllStarSystemsAsync(bool includeSpaceObjects = true);

        Task<SpaceObject> GetSpaceObjectAsync(Guid id, bool includeStarSystem = true);

        Task<StarSystem> GetStarSystemAsync(Guid id, bool includeStarSystem = true);

        Task<IEnumerable<StarSystem>> GetStarSystemsByPredicateAsync(Expression<Func<StarSystem, bool>> predicate, bool includeSpaceObjects = true);
        Task<SpaceObjectDTO> UpdateSpaceObject(Guid id, SpaceObjectDTO spaceObjectDTO);
    }
}