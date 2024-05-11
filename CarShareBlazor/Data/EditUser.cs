using CarShareBlazor.Models.Entities;
using CarShareBlazor.Models.ViewModels;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class EditUser
    {
        public async Task<UserModel?> EditUserAsync(UserModel user)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync("api/User", content);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<UserModel>(responseContent);
            }
            return null;
        }
    }
}
