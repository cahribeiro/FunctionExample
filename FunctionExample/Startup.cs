using FunctionExample.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.IO;
using System.Net.Http.Headers;

[assembly: FunctionsStartup(typeof(FunctionExample.Startup))]
namespace FunctionExample
{
    public class Startup : FunctionsStartup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var serviceProvider = builder.Services.BuildServiceProvider();
            var config = serviceProvider.GetRequiredService<IConfiguration>();

            builder.Services.AddHttpClient<IGitHubService, GitHubService>(c =>
            {
                var productValue = new ProductInfoHeaderValue("AzureFunction", "1.0");
                c.DefaultRequestHeaders.UserAgent.Add(productValue);
                c.BaseAddress = new Uri(config.GetValue<string>("GitHubUrl"));
            });

            //Serilog
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            builder.Services.AddLogging(loggingBuilder =>
            {                
                loggingBuilder.AddSerilog(logger);
            });

        }

        // This method gets called by the runtime. Use this method to configure the app configuration.
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            base.ConfigureAppConfiguration(builder);

            FunctionsHostBuilderContext context = builder.GetContext();

            builder.ConfigurationBuilder
                .AddJsonFile(Path.Combine(context.ApplicationRootPath, "local.settings.json"), optional: true, reloadOnChange: false);



        }
    }
}
