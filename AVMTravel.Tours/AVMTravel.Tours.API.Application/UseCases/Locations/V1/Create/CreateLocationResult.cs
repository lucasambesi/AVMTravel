namespace AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create
{
    public class CreateLocationResult
    {
        public bool Created { get; set; }

        public CreateLocationResult(bool created)
        {
            Created = created;
        }        
    }
}
