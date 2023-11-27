namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Delete
{
    public class DeleteTourResult
    {
        public bool Deleted { get; set; }

        public DeleteTourResult(bool deleted)
        {
            Deleted = deleted;
        }
    }
}
