namespace CarShareBlazor.Data
{
    public class DeletePersonCar
    {
        public async Task<string?> DeletePersonCarAsync(int personID, int carID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            HttpResponseMessage response = await client.DeleteAsync($"api/PersonCar/{carID}/{personID}");
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
