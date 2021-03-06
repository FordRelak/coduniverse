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

        public async Task<IEnumerable<StarSystemDTO>> GetAllStarSystemsAsync(bool includeSpaceObjects = true)
        {
            if(includeSpaceObjects)
                return _mapper.Map<List<StarSystemDTO>>(await _repositories.StarSystem.GetAsync(null, i => i.SpaceObjects, i => i.CenterMass));
            return _mapper.Map<List<StarSystemDTO>>(await _repositories.StarSystem.GetAsync(null, i => i.CenterMass));
        }

        public async Task<StarSystemDTO> GetStarSystemAsync(Guid id, bool includeSpaceObjects = true)
        {
            if(includeSpaceObjects)
                return _mapper.Map<StarSystemDTO>(await _repositories.StarSystem.GetAsync(id, i => i.SpaceObjects, i => i.CenterMass));
            return _mapper.Map<StarSystemDTO>(await _repositories.StarSystem.GetAsync(id, i => i.CenterMass));
        }

        public async Task<IEnumerable<StarSystemDTO>> GetStarSystemsByPredicateAsync(Expression<Func<StarSystem, bool>> predicate, bool includeSpaceObjects = true)
        {
            if(includeSpaceObjects)
                return _mapper.Map<List<StarSystemDTO>>(await _repositories.StarSystem.GetAsync(predicate, i => i.SpaceObjects));
            return _mapper.Map<List<StarSystemDTO>>(await _repositories.StarSystem.GetAsync(predicate));
        }

        public async Task MakeSpaceObjectCenterMass(Guid spaceObjectid, Guid starSystemId)
        {
            var starSystem = await _repositories.StarSystem.GetAsync(starSystemId, i => i.CenterMass);
            var spaceObject = await _repositories.SpaceObject.GetAsync(spaceObjectid);

            if(spaceObject != null && starSystem != null)
            {
                try
                {
                    await BeforeSaveAction();
                    starSystem.CenterMass = spaceObject;
                    await _repositories.StarSystem.UpdateAsync(starSystem);
                    await AfterSaveAction();
                }
                catch(Exception)
                {
                    await ErrorSaveAction();
                    throw;
                }
            }
        }

        public async Task<StarSystemDTO> UpdateStarSystem(Guid id, StarSystemDTO starSystemDTO)
        {
            try
            {
                if(starSystemDTO is null)
                    throw new ArgumentNullException(nameof(starSystemDTO));

                if(id == Guid.Empty)
                    return null;

                var starSystem = await _repositories.StarSystem.GetAsync(id);
                if(starSystem is null)
                    return null;

                await BeforeSaveAction();

                var update = _mapper.Map(starSystemDTO, starSystem);
                await _repositories.StarSystem.UpdateAsync(update);

                await AfterSaveAction();

                return starSystemDTO;
            }
            catch(Exception)
            {
                await ErrorSaveAction();
                throw;
            }
        }

        public async Task<StarSystemDTO> CreateStarSystem(StarSystemDTO starSystemDTO)
        {
            if(starSystemDTO is null)
            {
                throw new ArgumentNullException(nameof(starSystemDTO));
            }

            var newStarSystem = _mapper.Map<StarSystem>(starSystemDTO);
            try
            {
                await BeforeSaveAction();
                await _repositories.StarSystem.InsertAsync(newStarSystem);
                await AfterSaveAction();
                return _mapper.Map<StarSystemDTO>(newStarSystem);
            }
            catch(Exception)
            {
                await ErrorSaveAction();
                throw;
            }

        }

        public async Task DeleteStarSystemAsync(Guid id)
        {
            if(id == Guid.Empty)
                return;

            var starSystem = await _repositories.StarSystem.GetAsync(id);
            if(starSystem is null)
                return;

            await _repositories.StarSystem.Remove(starSystem);
            return;
        }

        #endregion StarSystem

        #region SpaceObject

        public async Task<SpaceObjectDTO> CreateSpaceObject(SpaceObjectDTO spaceObjectDto)
        {
            try
            {
                if(spaceObjectDto is null)
                    return null;

                if(spaceObjectDto.StarSystemId == Guid.Empty)
                    return null;

                var newSpaceObject = _mapper.Map<SpaceObject>(spaceObjectDto);
                var starSystem = await _repositories.StarSystem.GetAsync(spaceObjectDto.StarSystemId, i => i.SpaceObjects);

                await BeforeSaveAction();

                starSystem.SpaceObjects.Add(newSpaceObject);

                await _repositories.StarSystem.UpdateAsync(starSystem);

                await AfterSaveAction();

                return _mapper.Map<SpaceObjectDTO>(newSpaceObject);
            }
            catch(Exception)
            {
                await ErrorSaveAction();
                throw;
            }
        }

        public async Task<IEnumerable<SpaceObjectDTO>> GetAllSpaceObjectAsync(bool includeStarSystem = true)
        {
            if(includeStarSystem)
                return _mapper.Map<List<SpaceObjectDTO>>(await _repositories.SpaceObject.GetAsync(null, i => i.StarSystem));
            return _mapper.Map<List<SpaceObjectDTO>>(await _repositories.SpaceObject.GetAsync(null));
        }

        public async Task<SpaceObjectDTO> GetSpaceObjectAsync(Guid id, bool includeStarSystem = true)
        {
            if(includeStarSystem)
                return _mapper.Map<SpaceObjectDTO>(await _repositories.SpaceObject.GetAsync(id, i => i.StarSystem));
            return _mapper.Map<SpaceObjectDTO>(await _repositories.SpaceObject.GetAsync(id));
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