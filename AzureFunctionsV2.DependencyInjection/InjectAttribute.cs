using System;
using Microsoft.Azure.WebJobs.Description;

namespace AzureFunctionsV2.DependencyInjection
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class InjectAttribute : Attribute
    {
    }
}
