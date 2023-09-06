using System;
using System.Threading.Tasks;
using System.Net.Http;
namespace RobotPunchAutomation.Resources.Helpers

{
    public class ApiRequestFactory
    {
        public static async Task<HttpResponseMessage> SendRequest(String requestEndpoint)
        {
            // Create a new HttpClient
            HttpClient httpClient = new HttpClient();
            
            try
            {
                Console.WriteLine("Attempting API call...");
                HttpResponseMessage response = await httpClient.GetAsync(requestEndpoint);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("API call successful!");
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Received content: {content}");
                    //CryptoData obj = JsonConvert.DeserializeObject<CryptoData>(content);
                    //Console.WriteLine($"Bitcoin Price in USD: {obj.Bitcoin.Usd}");
                    return response;
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve data: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Print any exceptions that occur
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}