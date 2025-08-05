using BlazorSmallExercises.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorSmallExercises.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddSingleton<IGlobalProductList, GlobalProductList>();

            await builder.Build().RunAsync();
        }
    }
}
