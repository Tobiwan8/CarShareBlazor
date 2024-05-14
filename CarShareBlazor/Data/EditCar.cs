using CarShareBlazor.Models.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class EditCar
    {
        public async Task<string?> EditCarAsync(EditCarDTO car)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var json = JsonConvert.SerializeObject(car);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync("api/Car", content);
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
