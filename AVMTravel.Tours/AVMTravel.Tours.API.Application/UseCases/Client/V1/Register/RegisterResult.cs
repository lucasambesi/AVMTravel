namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.Register
{
    public class RegisterResult
    {
        public bool Created { get; set; }

        public RegisterResult(bool created)
        {
            Created = created;
        }
    }
}
