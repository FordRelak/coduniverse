﻿using Coduniverse.Application.Abstractions.Models;
using Coduniverse.Domain;
using System.Linq.Expressions;

namespace Coduniverse.Application.Abstractions
{
    public interface IUnitOfWorkService
    {
        Task<SpaceObjectDTO> CreateSpaceObject(SpaceObjectDTO spaceObjectDto);
        Task DeleteSpaceObjectAsync(Guid id);
        Task<IEnumerable<SpaceObjectDTO>> GetAllSpaceObjectAsync(bool includeStarSystem = true);
        Task<IEnumerable<StarSystemDTO>> GetAllStarSystemsAsync(bool includeSpaceObjects = true);
        Task<SpaceObjectDTO> GetSpaceObjectAsync(Guid id, bool includeStarSystem = true);
        Task<StarSystemDTO> GetStarSystemAsync(Guid id, bool includeSpaceObjects = true);
        Task<IEnumerable<StarSystemDTO>> GetStarSystemsByPredicateAsync(Expression<Func<StarSystem, bool>> predicate, bool includeSpaceObjects = true);
        Task<SpaceObjectDTO> UpdateSpaceObject(Guid id, SpaceObjectDTO spaceObjectDTO);
    }
}