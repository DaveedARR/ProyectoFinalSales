using System.Text;
using System.Text.Json;

namespace Sales.Infrastructure.Gateway.Identity
{
    public class IdentityService
    {
        private static readonly HttpClient httpClient = new HttpClient();
        string url = "https://localhost:7187/api/Auth/Login";

        public async Task<Response?> PostRequestAsync(Request request)
        {
            try
            {
                var jsonContent = JsonSerializer.Serialize(request);
                var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, httpContent);

                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<Response>(jsonResponse, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during POST: {ex.Message}");
                return null;
            }
        }

    }
}
