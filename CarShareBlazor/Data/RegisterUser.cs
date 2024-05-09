using CarShareBlazor.Models.DTOs;
using CarShareBlazor.Models.Entities;
using CarShareBlazor.Models.ViewModels;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class RegisterUser
    {
        public async Task<UserModel?> RegisterUserAsync(LoginViewModel user)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            string json = JsonConvert.SerializeObject(user);
            StringContent content = new(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("api/User", content);
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                UserModel? userModel = JsonConvert.DeserializeObject<UserModel>(responseContent);

                return userModel;
            }
            return null;
        }
    }
}
