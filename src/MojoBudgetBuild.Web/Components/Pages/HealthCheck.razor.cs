using Microsoft.AspNetCore.Components;

namespace MojoBudgetBuild.Web.Components.Pages;

public partial class HealthCheck : ComponentBase
{
    private Dictionary<string, string> status;
    private Dictionary<string, string> greetings;

    protected override async Task OnInitializedAsync()
    {
        status = new Dictionary<string, string>();
        greetings = new Dictionary<string, string>();

        var services = new Dictionary<string, string>
        {
            { "service1", "hello" },
            { "service2", "howdy" },
            { "service3", "greetings" }
        };

        foreach (var service in services)
        {
            bool isHealthy = await ApiClient.CheckServiceHealthAsync(service.Key, service.Value);
            status[service.Key] = isHealthy ? "Healthy" : "Unhealthy";

            var greetingMessage = await ApiClient.GetGreetingAsync(service.Key, service.Value);
            greetings[service.Key] = greetingMessage;
        }
    }
}