using AzureFunctionsV2.DependencyInjection;
using AzureFunctionsV2DI;
using AzureFunctionsV2DI.Service;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

[assembly: WebJobsStartup(typeof(WebJobsExtensionStartup), "A Web Jobs Extension Sample")]
namespace AzureFunctionsV2DI
{
    public class WebJobsExtensionStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            var config = builder.Services.FirstOrDefault(p => p.ServiceType == typeof(IConfiguration))?.ImplementationInstance as IConfiguration;

            string testValue = config.GetValue<string>("Test");

            builder.Services.AddSingleton<IDemoService>(new DemoService(testValue));

            builder.Services.AddSingleton<InjectBindingProvider>();
            builder.AddExtension<InjectConfiguration>();
        }
    }
}
