using CarShareBlazor.Models.Entities;
using Newtonsoft.Json;

namespace CarShareBlazor.Data
{
    public class GetUserCars
    {
        public async Task<List<CarModel>?> GetUserCarsAsync(int personID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var requestUrl = $"/api/PersonCar/byPersonID/{personID}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<CarModel>>(responseContent);
            }
            return null;
        }
    }
}
