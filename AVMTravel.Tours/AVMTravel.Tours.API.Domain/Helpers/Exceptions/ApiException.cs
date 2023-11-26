using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Domain.Helpers.Exceptions
{
    public class ApiException : Exception
    {
        public EErrorCodeType Code { get; set; }

        public ApiException(string message, EErrorCodeType code) : base(message)
        {
            Code = code;
        }
    }
}
