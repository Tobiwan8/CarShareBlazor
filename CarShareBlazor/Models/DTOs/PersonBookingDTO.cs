namespace CarShareBlazor.Models.DTOs
{
    public class PersonBookingDTO
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? CarName { get; set; }
    }
}
