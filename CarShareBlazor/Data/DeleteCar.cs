namespace CarShareBlazor.Data
{
    public class DeleteCar
    {
        public async Task<string?> DeleteCarAsync(int carID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            HttpResponseMessage response = await client.DeleteAsync($"api/Car?carID={carID}");
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
