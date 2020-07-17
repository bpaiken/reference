using Disclone.Host.Api;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Disclone.Host.Api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IRepository, Repository>();
            // or one of the options below
            // builder.Services.AddScoped<IRepository, Repository>();
            // builder.Services.AddTransient<IRepository, Repository>();
            builder.Services.AddLogging();
        }
    }

    public interface IRepository
    {
        string GetData();
    }
    public class Repository : IRepository
    {
        public string GetData()
        {
            return "some data!";
        }
    }
}
