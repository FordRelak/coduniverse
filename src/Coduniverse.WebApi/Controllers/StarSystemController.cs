using Coduniverse.Application.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Coduniverse.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarSystemController : ControllerBase
    {
        private readonly IUnitOfWorkService _services;

        public StarSystemController(IUnitOfWorkService services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _services.GetAllStarSystemsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _services.GetStarSystemAsync(id));
        }
    }
}
