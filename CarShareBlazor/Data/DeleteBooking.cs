namespace CarShareBlazor.Data
{
    public class DeleteBooking
    {
        public async Task<string?> DeleteBookingAsync(int bookingID)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri(APIRoot.APIRootAddress)
            };

            HttpResponseMessage response = await client.DeleteAsync($"api/Booking?bookingID={bookingID}");
            if (response.IsSuccessStatusCode)
            {
                return "ok";
            }
            return null;
        }
    }
}
