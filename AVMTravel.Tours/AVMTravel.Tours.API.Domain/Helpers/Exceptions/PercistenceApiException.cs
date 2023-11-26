using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Domain.Helpers.Exceptions
{
    public class PercistenceApiException : ApiException
    {
        public PercistenceApiException(string message, EErrorCodeType code) : base(message, code)
        {
        }
    }
}
