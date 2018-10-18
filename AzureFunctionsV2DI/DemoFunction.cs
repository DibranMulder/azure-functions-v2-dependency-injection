using AzureFunctionsV2.DependencyInjection;
using AzureFunctionsV2DI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsV2DI
{
    public static class DemoFunction
    {
        [FunctionName("DemoFunction")]
        public static IActionResult Run(
            [HttpTrigger(
                AuthorizationLevel.Anonymous,
                "get", Route = "demo")
            ] HttpRequest req,
            [Inject] IDemoService demoService,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var res = demoService.GetResponse();

            log.LogInformation($"Res = {res}");

            return new OkObjectResult(res);
        }
    }
}
