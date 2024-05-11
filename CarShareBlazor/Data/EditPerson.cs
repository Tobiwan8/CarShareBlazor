using CarShareBlazor.Models.DTOs;
using CarShareBlazor.Models.Entities;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class EditPerson
    {
        public async Task<string?> EditPersonAsync(EditPersonDTO person)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            var json = JsonConvert.SerializeObject(person);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync("api/Person", content);
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
