using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coduniverse.WebApi.Tests.Controllers
{
    public class StarSystemControllerTests
    {
        private readonly IMapper _mapper;

        public StarSystemControllerTests()
        {
            _mapper = new Mapper(new MapperConfiguration(config => config.AddMaps(AppDomain.CurrentDomain.GetAssemblies())));
        }


    }
}
