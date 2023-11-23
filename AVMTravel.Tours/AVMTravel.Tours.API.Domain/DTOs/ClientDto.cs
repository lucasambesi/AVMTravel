namespace AVMTravel.Tours.API.Domain.DTOs
{
    public class ClientDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }
    }
}
