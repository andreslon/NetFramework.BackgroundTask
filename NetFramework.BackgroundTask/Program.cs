using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace NetFramework.BackgroundTask
{
    class Program
    { 
        static void Main(string[] args)
        { 
            BuildHost(args).Build().Run();
        } 

        public static IHostBuilder BuildHost(string[] args) =>
                 new HostBuilder()
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    //config.SetBasePath(Environment.CurrentDirectory);
                    //config.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true);
                    //config.AddEnvironmentVariables();
                    //config.AddCommandLine(args);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<HostedService>();

                    //#region Core services
                    //services.AddScoped<ICustomerService, CustomerService>();
                    //#endregion

                    //#region Repositories
                    //services.AddScoped<ICustomerRepository, CustomerRepository>();
                    //#endregion
                });
    }
}