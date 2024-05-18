namespace CarShareBlazor.Models.DTOs
{
    public class AddBookingDTO
    {
        public int PersonID { get; set; }
        public int CarID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
