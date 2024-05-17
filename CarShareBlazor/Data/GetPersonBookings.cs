using CarShareBlazor.Models.DTOs;
using Newtonsoft.Json;

namespace CarShareBlazor.Data
{
    public class GetPersonBookings
    {
        public async Task<List<PersonBookingDTO>?> GetPersonBookingsAsync(int personID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var requestUrl = $"/api/Booking/personID/{personID}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<PersonBookingDTO>>(responseContent);
            }
            return null;
        }
    }
}
