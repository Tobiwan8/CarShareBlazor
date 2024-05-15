namespace CarShareBlazor.Models.DTOs
{
    public class CarBookingDTO
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? PersonFullName { get; set; }
    }
}
