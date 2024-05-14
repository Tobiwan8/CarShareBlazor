using CarShareBlazor.Models.DTOs;
using CarShareBlazor.Models.Entities;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class GetPersonByUserName
    {
        public async Task<GetPersonByUserNameDTO?> GetPersonByUserNameAsync(string userName)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var queryString = new StringBuilder();
            queryString.Append("?userName=").Append(Uri.EscapeDataString(userName));

            var requestUrl = "/api/User/username" + queryString.ToString();

            HttpResponseMessage response = await client.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<GetPersonByUserNameDTO>(responseContent);
            }
            return null;
        }
    }
}
