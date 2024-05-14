using CarShareBlazor.Models.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class AddPersonCar
    {
        public async Task<string?> AddPersonCarAsync(AddPersonCarDTO personCar)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            string json = JsonConvert.SerializeObject(personCar);
            StringContent content = new(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("api/PersonCar", content);
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
