using AutoMapper;
using Coduniverse.Application.Abstractions.Models;
using Coduniverse.Domain;

namespace Coduniverse.Application.Services.Utils.AutoMapperProfiles
{
    public class ServiceProfiles : Profile
    {
        public ServiceProfiles()
        {
            CreateMap<SpaceObjectDTO, SpaceObject>();
        }
    }
}