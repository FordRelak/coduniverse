using AutoMapper;
using Coduniverse.Application.Abstractions;
using Coduniverse.Application.Abstractions.Models;
using Coduniverse.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coduniverse.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpaceObjectController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkService _services;
        public SpaceObjectController(IUnitOfWorkService services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(SpaceObjectInput model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _services.CreateSpaceObject(_mapper.Map<SpaceObjectDTO>(model));

            return Created(nameof(Create), created.Id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _services.DeleteSpaceObjectAsync(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dto = await _services.GetSpaceObjectAsync(id);
            if (dto == null)
                return NotFound();
            return Ok(dto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(SpaceObjectInput model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = await _services.UpdateSpaceObject(model.Id, _mapper.Map<SpaceObjectDTO>(model));
            return Ok(updated);
        }
    }
}