using System.Text;
using System.Text.Json;

namespace Sales.Infrastructure.Gateway.Payment
{
    public class PaymentService
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string baseUrl = "https://localhost:7062/api/Pago/Registrar";

        public async Task<bool> RegisterPaymentAsync(PagoDto pago)
        {
            try
            {
                var jsonContent = JsonSerializer.Serialize(pago);
                var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(baseUrl, httpContent);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during POST to PaymentService: {ex.Message}");
                return false;
            }
        }
    }
}
