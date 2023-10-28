using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Services
{
    public class HomeServices
    {
        private readonly HttpClient _httpClient;
        public HomeServices(HttpClient httpClient) => _httpClient = httpClient; 

        private readonly string Apikey = "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI0MTRmZTUzNjg2MzE1NzViZDc4NTZjMzU2YTcxZDI2NSIsInN1YiI6IjYzZWVhZTBjN2NmZmRhMDA4ZWMxNTYyOSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.zp6musWyqQg0bV_1Od0gYxOnwpayjq3iaEbi2c-cgdU";

        public async Task<ActionResult<string>> HomeGet(string url)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", Apikey);
                _httpClient.DefaultRequestHeaders.Add("accept", "application/json");

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
