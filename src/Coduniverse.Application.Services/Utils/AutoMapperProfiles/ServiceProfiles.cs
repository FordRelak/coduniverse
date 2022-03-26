using AutoMapper;
using Coduniverse.Application.Abstractions.Models;
using Coduniverse.Domain;

namespace Coduniverse.Application.Services.Utils.AutoMapperProfiles
{
    public class ServiceProfiles : Profile
    {
        public ServiceProfiles()
        {
            CreateMap<StarSystemDTO, StarSystem>()
                .ReverseMap();
            CreateMap<SpaceObject, SpaceObjectDTO>()
                .ForMember(dst => dst.TypeName, opt => opt.MapFrom(src => src.Type.ToString()));
            CreateMap<SpaceObjectDTO, SpaceObject>();
        }
    }
}