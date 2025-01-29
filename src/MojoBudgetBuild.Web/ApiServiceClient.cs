namespace MojoBudgetBuild.Web;

public class ApiServiceClient
{
    private readonly HttpClient _httpClient;

    public ApiServiceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // General API Call to fetch greeting message
    public async Task<string> GetGreetingAsync(string serviceName, string controller)
    {
        string url = $"/{serviceName}/{controller}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _httpClient.SendAsync(request);

        if (!response.IsSuccessStatusCode)
        {
            return $"Error: {response.StatusCode}";
        }

        return await response.Content.ReadAsStringAsync();
    }

    // Health Check Call
    public async Task<bool> CheckServiceHealthAsync(string serviceName, string controller)
    {
        string url = $"/{serviceName}/{controller}/health";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _httpClient.SendAsync(request);
        return response.IsSuccessStatusCode;
    }
}