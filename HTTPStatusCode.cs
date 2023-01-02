namespace GM.Model
{
    public enum HTTPStatusCode
    {
        OK = 200,
        Created = 201,
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        Conflict = 409,
        LengthRequired = 411,
        PreconditionFailed = 412,
        TooManyRequests = 429,
        InternalServerError = 500,
        ServiceUnavailable = 503
    }
}
