using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Domain.Helpers.Exceptions
{
    public class ValidationApiException : ApiException
    {
        public List<string> Errors { get; }

        public ValidationApiException(List<string> errors)
            : base("Validation errors.", EErrorCodeType.BadRequest)
        {
            Errors = errors;
        }
    }
}
