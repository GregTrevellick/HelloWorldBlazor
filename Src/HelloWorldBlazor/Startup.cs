using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorldBlazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
        }

        public void Configure(IBlazorApplicationBuilder blazorApplicationBuilder)
        {
            blazorApplicationBuilder.AddComponent<MyApp>("myApp");
        }
    }
}
