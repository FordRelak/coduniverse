using AutoMapper;
using Coduniverse.Application.Abstractions.Models;
using Coduniverse.WebApi.Models;

namespace Coduniverse.WebApi.Utils.AutoMapperProfiles
{
    public class InputModelProfile : Profile
    {
        public InputModelProfile()
        {
            CreateMap<SpaceObjectInput, SpaceObjectDTO>();
            CreateMap<StarSystemInput, StarSystemDTO>();
        }
    }
}