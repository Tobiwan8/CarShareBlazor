using CarShareBlazor.Models.Entities;
using CarShareBlazor.Models.ViewModels;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class GetOwnedCars
    {
        public async Task<List<CarModel>?> GetOwnedCarsAsync(int personID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            // Build query parameters from the login view model
            var queryString = new StringBuilder();
            queryString.Append("?personID=").Append(Uri.EscapeDataString(personID.ToString()));

            // Construct the full URL with query parameters
            var requestUrl = "api/Car/owner" + queryString.ToString();

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
