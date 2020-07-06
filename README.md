# OcelotExtensions
为 Ocelot 提供更易用的 ASP.NET Core 集成接口。

## 安装
```xml
<PackageReference Include="NXHub.Extensions.Ocelot" Version="0.0.2" />
```

## 使用
```cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddOcelot(config =>
    {
        // other settings.
        
        config.GlobalConfiguration.BaseUrl = "http://localhost";
    });
    
    // ...
}
```
