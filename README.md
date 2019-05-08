**This repo has become deprecated, please use the native dependency injection https://github.com/Azure/azure-functions-dotnet-extensions/tree/master/src/samples/DependencyInjection/Basic**

# Azure Functions V2 Dependency Injection
Created this repo because of breaking changes made to the Azure Functions V2 runtime.
Read more about this in [this thread](https://github.com/Azure/azure-webjobs-sdk/issues/1865)

This demo Functions App will provide a Function with an Http trigger.
The function will get a demo service injected and that demo service will get some settings injected from the `local.settings.json`

Note that you have to run with the Azure Functions Core Tools 2.0.1-beta.36 or higher
## Example
```bash

                  %%%%%%
                 %%%%%%
            @   %%%%%%    @
          @@   %%%%%%      @@
       @@@    %%%%%%%%%%%    @@@
     @@      %%%%%%%%%%        @@
       @@         %%%%       @@
         @@      %%%       @@
           @@    %%      @@
                %%
                %

Azure Functions Core Tools (2.0.1-beta.36)
Function Runtime Version: 2.0.12050.0
info: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[0]
      User profile is available. Using '<secret>' as key repository and Windows DPAPI to encrypt keys at rest.
info: Host.Startup[0]
      Reading host configuration file '<secret>AzureFunctionsV2DI\AzureFunctionsV2DI\bin\Debug\netstandard2.0\host.json'
info: Host.Startup[0]
      Host configuration file read:
      {
        "version": "2.0"
      }
[6-9-2018 12:53:34] Initializing Host.
[6-9-2018 12:53:34] Host initialization: ConsecutiveErrors=0, StartupCount=1
[6-9-2018 12:53:34] Starting JobHost
[6-9-2018 12:53:34] Starting Host (HostId=desktopgb361u0-631645672, InstanceId=9640d50a-7409-49af-b20f-d23f0df54e2a, Version=2.0.12050.0, ProcessId=38508, AppDomainId=1, Debug=False, FunctionsExtensionVersion=)
[6-9-2018 12:53:35] Generating 1 job function(s)
[6-9-2018 12:53:35] Found the following functions:
[6-9-2018 12:53:35] AzureFunctionsV2DI.DemoFunction.Run
[6-9-2018 12:53:35]
[6-9-2018 12:53:35] Host initialized (270ms)
[6-9-2018 12:53:35] Host started (283ms)
[6-9-2018 12:53:35] Job host started
Hosting environment: Production
Content root path: <secret>AzureFunctionsV2DI\AzureFunctionsV2DI\bin\Debug\netstandard2.0
Now listening on: http://0.0.0.0:7071
Application started. Press Ctrl+C to shut down.
Listening on http://0.0.0.0:7071/
Hit CTRL-C to exit...

Http Functions:

        DemoFunction: http://localhost:7071/api/demo
```
