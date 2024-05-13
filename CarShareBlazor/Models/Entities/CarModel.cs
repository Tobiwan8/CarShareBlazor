namespace CarShareBlazor.Models.Entities
{
    public class CarModel
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Licenseplate { get; set; }
        public int OwnerID { get; set; }
    }
}
