using System;
using AzureFunctionsV2.DependencyInjection;
using AzureFunctionsV2DI;
using AzureFunctionsV2DI.Service;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: WebJobsStartup(typeof(WebJobsExtensionStartup), "A Web Jobs Extension Sample")]
namespace AzureFunctionsV2DI
{
    public class WebJobsExtensionStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            var testValue = config.GetValue<string>("Test");

            builder.Services.AddSingleton<IDemoService>(new DemoService(testValue));

            builder.Services.AddSingleton<InjectBindingProvider>();
            builder.AddExtension<InjectConfiguration>();
        }
    }
}
