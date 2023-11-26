using AutoMapper;
using AVMTravel.Tours.API.NIntegrationTests.Mappings;

namespace AVMTravel.Tours.API.NIntegrationTests.Common
{
    public class MapperMock
    {
        private IMapper _mapper;

        public MapperMock()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingLocationTest());
            });

            _mapper = mapConfig.CreateMapper();
        }


        public IMapper GetMapper() => _mapper;
    }
}
