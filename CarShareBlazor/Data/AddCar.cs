using CarShareBlazor.Models.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class AddCar
    {
        public async Task<string?> AddCarAsync(AddCarDTO car)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            string json = JsonConvert.SerializeObject(car);
            StringContent content = new(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("api/Car", content);
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
