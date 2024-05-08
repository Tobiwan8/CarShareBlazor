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
            //PASTED FROM LOGINUSER

            //using HttpClient client = new()
            //{
            //    BaseAddress = new Uri(APIRoot.APIRootAddress)
            //};

            //// Build query parameters from the login view model
            //var queryString = new StringBuilder();
            //queryString.Append("?username=").Append(Uri.EscapeDataString(user.UserName!));
            //queryString.Append("&password=").Append(Uri.EscapeDataString(user.Password!));

            //// Construct the full URL with query parameters
            //var requestUrl = "api/User/user" + queryString.ToString();

            //HttpResponseMessage response = await client.GetAsync(requestUrl);
            //if (response.IsSuccessStatusCode)
            //{
            //    string responseContent = await response.Content.ReadAsStringAsync();

            //    return JsonConvert.DeserializeObject<UserModel>(responseContent);
            //}
            //return null;
        }
    }
}
