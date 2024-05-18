using CarShareBlazor.Models.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class AddBooking
    {
        public async Task<string?> AddBookingAsync(AddBookingDTO booking)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            string json = JsonConvert.SerializeObject(booking);
            StringContent content = new(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("api/Booking", content);
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
