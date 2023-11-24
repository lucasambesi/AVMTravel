namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update
{
    public class UpdateTourResult
    {
        public bool Updated { get; set; }

        public UpdateTourResult(bool updated)
        {
            Updated = updated;
        }
    }
}
