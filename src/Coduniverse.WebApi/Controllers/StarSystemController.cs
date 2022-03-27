using AutoMapper;
using Coduniverse.Application.Abstractions;
using Coduniverse.Application.Abstractions.Models;
using Coduniverse.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Coduniverse.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarSystemController : ControllerBase
    {
        private readonly IUnitOfWorkService _services;
        private readonly IMapper _mapper;

        public StarSystemController(IUnitOfWorkService services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _services.GetAllStarSystemsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dto = await _services.GetStarSystemAsync(id, false);
            if(dto == null)
                return NotFound();
            return Ok(dto);
        }

        [HttpPost("centermass")]
        public async Task<IActionResult> MakeCenterMass(MakeCenterMassInput model)
        {
            await _services.MakeSpaceObjectCenterMass(model.SpaceObjectId, model.StarSystemId);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(StarSystemInput starSystem)
        {
            if(!ModelState.IsValid || starSystem.Id == Guid.Empty)
                return BadRequest(ModelState);

            var updated = await _services.UpdateStarSystem(starSystem.Id, _mapper.Map<StarSystemDTO>(starSystem));
            return Ok(updated);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StarSystemInput starSystem)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _services.CreateStarSystem(_mapper.Map<StarSystemDTO>(starSystem));

            return Created(nameof(Create), created.Id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _services.DeleteStarSystemAsync(id);
            return Ok();
        }
    }
}