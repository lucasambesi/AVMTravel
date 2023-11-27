namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create
{
    public class CreateReservationResult
    {
        public bool Created { get; set; }

        public CreateReservationResult(bool created)
        {
            Created = created;
        }
    }
}
