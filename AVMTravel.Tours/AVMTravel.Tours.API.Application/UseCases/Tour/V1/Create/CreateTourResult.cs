namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create
{
    public class CreateTourResult
    {
        public bool Created { get; set; }

        public CreateTourResult(bool created)
        {
            Created = created;
        }
    }
}
