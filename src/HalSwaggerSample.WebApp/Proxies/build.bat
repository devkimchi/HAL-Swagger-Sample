@echo off

..\..\packages\autorest.0.11.0\tools\AutoRest.exe -Input swagger.json -Namespace HalSwaggerSample.WebApp.Proxies -OutputDirectory ..\Proxies -CodeGenerator CSharp
