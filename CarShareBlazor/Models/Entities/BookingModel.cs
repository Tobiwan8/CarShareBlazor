namespace CarShareBlazor.Models.Entities
{
    public class BookingModel
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PersonID { get; set; }
        public int CarID { get; set; }
    }
}
