using AutoMapper;
using Coduniverse.Application.Abstractions;
using Coduniverse.Application.Abstractions.Models;
using Coduniverse.WebApi.Controllers;
using Coduniverse.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Coduniverse.WebApi.Tests.Controllers
{
    public class SpaceObjectControllerTests
    {
        private readonly Guid _guid = Guid.NewGuid();
        private readonly IMapper _mapper;

        public SpaceObjectControllerTests()
        {
            _mapper = new Mapper(new MapperConfiguration(config => config.AddMaps(AppDomain.CurrentDomain.GetAssemblies())));
        }

        [Fact]
        public async Task Get_Ok()
        {
            var mockRepo = new Mock<IUnitOfWorkService>();
            mockRepo.Setup(s => s.GetSpaceObjectAsync(_guid, true))
                .ReturnsAsync(new SpaceObjectDTO());

            var controller = new SpaceObjectController(mockRepo.Object, _mapper);
            var result = await controller.Get(_guid);
            var view = Assert.IsType<OkObjectResult>(result);
            Assert.IsType<SpaceObjectDTO>(view.Value);
        }

        [Fact]
        public async void Get_Error404()
        {
            var mockRepo = new Mock<IUnitOfWorkService>();
            mockRepo.Setup(s => s.GetSpaceObjectAsync(_guid, true))
                .ReturnsAsync(new SpaceObjectDTO());

            var controller = new SpaceObjectController(mockRepo.Object, _mapper);

            var result = await controller.Get(Guid.NewGuid());
            var view = Assert.IsType<NotFoundResult>(result);
            Assert.Equal(404, view.StatusCode);
        }

        [Fact]
        public async Task Create_Entity_Ok()
        {
            var input = new SpaceObjectInput()
            {
                Mass = 123,
            };

            var mockRepo = new Mock<IUnitOfWorkService>(MockBehavior.Strict);

            mockRepo.Setup(s => s.CreateSpaceObject(It.IsAny<SpaceObjectDTO>()))
                .ReturnsAsync(new SpaceObjectDTO());

            var controller = new SpaceObjectController(mockRepo.Object, _mapper);

            var result = await controller.Create(input);

            var view = Assert.IsType<CreatedResult>(result);
            var dtoView = Assert.IsType<Guid>(view.Value);
            Assert.Equal("Create", view.Location);
        }

        [Fact]
        public async Task Create_Entity_Error()
        {
            var input = new SpaceObjectInput()
            {
                Mass = 123,
            };

            var mockRepo = new Mock<IUnitOfWorkService>(MockBehavior.Strict);

            mockRepo.Setup(s => s.CreateSpaceObject(It.IsAny<SpaceObjectDTO>()))
                .ReturnsAsync(new SpaceObjectDTO());
            var controller = new SpaceObjectController(mockRepo.Object, _mapper);

            controller.ModelState.AddModelError("Age", "Required");

            var result = await controller.Create(input);

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }
}