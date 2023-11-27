namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.Login
{
    public class LoginResult
    {
        public string Token { get; set; }

        public LoginResult(string token)
        {
            Token = token;
        }
    }
}
