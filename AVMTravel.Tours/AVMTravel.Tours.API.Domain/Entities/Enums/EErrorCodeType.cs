namespace AVMTravel.Tours.API.Domain.Entities.Enums
{
    public enum EErrorCodeType
    {
        None,
        NotFound = 404,
        BadRequest = 400,
        Business = 422,
        Unauthorized = 401,
        InternalError = 500,
        Conflict = 409,
        ServiceUnavailable = 503,
        UnprocessableEntity = 422,
        PartiallySuccess = 206
    }
}
