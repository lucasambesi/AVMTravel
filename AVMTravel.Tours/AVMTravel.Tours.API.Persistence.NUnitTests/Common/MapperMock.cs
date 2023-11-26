using AutoMapper;
using AVMTravel.Tours.API.Persistence.Mappings;

namespace AVMTravel.Tours.API.Persistence.Common
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
