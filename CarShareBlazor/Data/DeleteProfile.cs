using CarShareBlazor.Models.DTOs;
using CarShareBlazor.Models.Entities;
using Newtonsoft.Json;
using System.Text;

namespace CarShareBlazor.Data
{
    public class DeleteProfile
    {
        public async Task<string?> DeleteUserAsync(int userID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            HttpResponseMessage response = await client.DeleteAsync($"api/User?userID={userID}");
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
