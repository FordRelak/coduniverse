using AutoMapper;
using Coduniverse.Application.Abstractions;
using Coduniverse.Application.Abstractions.Models;
using Coduniverse.Domain;
using Coduniverse.Infrastructure.Abstractions;
using System.Linq.Expressions;

namespace Coduniverse.Application.Services
{
    public class UOWService : IUnitOfWorkService
    {
        private readonly IUnitOfWorkRepository _repositories;
        private readonly IMapper _mapper;

        public UOWService(IUnitOfWorkRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        #region StarSystem

        public async Task<IEnumerable<StarSystem>> GetAllStarSystemsAsync(bool includeSpaceObjects = true)
        {
            if(includeSpaceObjects)
                return await _repositories.StarSystem.GetAsync(null, i => i.SpaceObjects, i => i.CenterMass);
            return await _repositories.StarSystem.GetAsync(null, i => i.CenterMass);
        }

        public async Task<StarSystem> GetStarSystemAsync(Guid id, bool includeSpaceObjects = true)
        {
            if(includeSpaceObjects)
                return await _repositories.StarSystem.GetAsync(id, i => i.SpaceObjects);
            return await _repositories.StarSystem.GetAsync(id, i => i.CenterMass);
        }

        public async Task<IEnumerable<StarSystem>> GetStarSystemsByPredicateAsync(Expression<Func<StarSystem, bool>> predicate, bool includeSpaceObjects = true)
        {
            if(includeSpaceObjects)
                return await _repositories.StarSystem.GetAsync(predicate, i => i.SpaceObjects);
            return await _repositories.StarSystem.GetAsync(predicate);
        }

        #endregion StarSystem

        #region SpaceObject

        public async Task<SpaceObject> CreateSpaceObject(SpaceObjectDTO spaceObjectDto)
        {
            try
            {
                if(spaceObjectDto is null)
                    return null;

                if(spaceObjectDto.StarSystemId == Guid.Empty)
                    return null;

                var newSpaceObject = _mapper.Map<SpaceObject>(spaceObjectDto);
                var starSystem = await GetStarSystemAsync(spaceObjectDto.StarSystemId);

                await BeforeSaveAction();

                starSystem.SpaceObjects.Add(newSpaceObject);

                await _repositories.StarSystem.UpdateAsync(starSystem);

                await AfterSaveAction();

                return newSpaceObject;
            }
            catch(Exception)
            {
                await ErrorSaveAction();
                throw;
            }
        }

        public async Task<IEnumerable<SpaceObject>> GetAllSpaceObjectAsync(bool includeStarSystem = true)
        {
            if(includeStarSystem)
                return await _repositories.SpaceObject.GetAsync(null, i => i.StarSystem);
            return await _repositories.SpaceObject.GetAsync(null);
        }

        public async Task<SpaceObject> GetSpaceObjectAsync(Guid id, bool includeStarSystem = true)
        {
            if(includeStarSystem)
                return await _repositories.SpaceObject.GetAsync(id, i => i.StarSystem);
            return await _repositories.SpaceObject.GetAsync(id);
        }

        public async Task<SpaceObjectDTO> UpdateSpaceObject(Guid id, SpaceObjectDTO spaceObjectDTO)
        {
            try
            {
                if(spaceObjectDTO is null)
                    throw new ArgumentNullException(nameof(spaceObjectDTO));

                if(id == Guid.Empty)
                    return null;

                var spaceObject = await _repositories.SpaceObject.GetAsync(id);
                if(spaceObject is null)
                    return null;

                await BeforeSaveAction();

                var update = _mapper.Map(spaceObjectDTO, spaceObject);
                await _repositories.SpaceObject.UpdateAsync(update);

                await AfterSaveAction();

                return spaceObjectDTO;
            }
            catch(Exception)
            {
                await ErrorSaveAction();
                throw;
            }
        }

        public async Task DeleteSpaceObjectAsync(Guid id)
        {
            if(id == Guid.Empty)
                return;

            var spaceObject = await _repositories.SpaceObject.GetAsync(id);
            if(spaceObject is null)
                return;

            await _repositories.SpaceObject.Remove(spaceObject);
            return;
        }

        #endregion SpaceObject

        private async Task AfterSaveAction() => await _repositories.CommitTransaction();

        private async Task BeforeSaveAction() => await _repositories.BeginTransaction();

        private async Task ErrorSaveAction() => await _repositories.RollbackTransaction();
    }
}