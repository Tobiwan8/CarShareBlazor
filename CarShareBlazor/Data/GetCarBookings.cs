using CarShareBlazor.Models.DTOs;
using CarShareBlazor.Models.Entities;
using Newtonsoft.Json;

namespace CarShareBlazor.Data
{
    public class GetCarBookings
    {
        public async Task<List<CarBookingDTO>?> GetCarBookingsAsync(int carID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var requestUrl = $"/api/Booking/carID/{carID}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<CarBookingDTO>>(responseContent);
            }
            return null;
        }
    }
}
