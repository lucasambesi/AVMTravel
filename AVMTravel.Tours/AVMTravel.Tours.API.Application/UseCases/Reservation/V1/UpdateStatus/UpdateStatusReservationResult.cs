namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus
{
    public class UpdateStatusReservationResult
    {
        public bool Updated { get; set; }

        public UpdateStatusReservationResult(bool updated)
        {
            Updated = updated;
        }
    }
}
