using CarShareBlazor.Models.Entities;
using CarShareBlazor.Models.ViewModels;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class GetUserByID
    {
        public async Task<UserModel?> GetUserByIDAsync(int userID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            // Build query parameters from the login view model
            var queryString = new StringBuilder();
            queryString.Append("?userID=").Append(Uri.EscapeDataString(userID.ToString()));

            // Construct the full URL with query parameters
            var requestUrl = "api/User/id" + queryString.ToString();

            HttpResponseMessage response = await client.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<UserModel>(responseContent);
            }
            return null;
        }
    }
}
