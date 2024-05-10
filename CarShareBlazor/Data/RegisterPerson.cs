using CarShareBlazor.Models.DTOs;
using CarShareBlazor.Models.Entities;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class RegisterPerson
    {
        public async Task<string?> RegisterUserAsync(RegisterPersonDTO person)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            string json = JsonConvert.SerializeObject(person);
            StringContent content = new(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("api/Person", content);
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
