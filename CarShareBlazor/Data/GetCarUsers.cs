using CarShareBlazor.Models.Entities;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class GetCarUsers
    {
        public async Task<List<PersonModel>?> GetCarUsersAsync(int carID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var requestUrl = $"/api/PersonCar/byCarID/{carID}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<PersonModel>>(responseContent);
            }
            return null;
        }
    }
}
