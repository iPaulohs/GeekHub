using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Services
{
    public class HomeServices
    {
        private readonly HttpClient _httpClient;
        public HomeServices(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<ActionResult<string>> HomeGet(string url)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", "Apikey");
                _httpClient.DefaultRequestHeaders.Add("accept", "application/json");
                Console.WriteLine("Api: ApiKey");

                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else
                {
                    return $"Status Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"Error code: {ex}";
            }
        }
    }
}
