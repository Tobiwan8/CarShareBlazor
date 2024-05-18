using CarShareBlazor.Models.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class EditBooking
    {
        public async Task<string?> EditBookingAsync(EditBookingDTO booking)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var json = JsonConvert.SerializeObject(booking);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync("api/Booking", content);
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
