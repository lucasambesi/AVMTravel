using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Domain.Helpers.Exceptions
{
    public class ApplicationApiException : ApiException
    {
        public ApplicationApiException(string message, EErrorCodeType code) : base(message, code)
        {
        }
    }
}
