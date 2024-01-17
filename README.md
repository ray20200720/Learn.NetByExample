# 如何開發的nuget package?

先建立一個 AppLogger 資料夾,並建立 classlib 專案

``` sh
mkdir AppLogger
cd AppLogger
dotnet new classlib
```

在 `AppLogger.csproj` 添加

``` xml
<PackageId>MyAppLogger</PackageId>
<Version>1.0.0</Version>
<Authors>Ray Kuo</Authors>
<Company>IT Help Company</Company>
```

執行 `dotnet pack` 會生成 `MyAppLogger.1.0.0.nupkg` 壓縮包


# 如何安裝自己開發的nuget package?

將建立好的package `MyAppLogger.1.0.0.nupkg` 拷貝到 `D:\NuGet` 目錄下

建立一個 TestMyAppLogger 資料夾,並建立 console 專案

``` sh
mkdir TestMyAppLogger
cd TestMyAppLogger
dotnet new console
```

生成 `nugetconfig` 檔案

``` 
dotnet new nugetconfig
```

移除遠端的nuget source

``` sh
dotnet nuget remove source nuget
```

添加本地的nuget source

``` sh
dotnet nuget add source "D:\NuGet" -n local
```

在專案安裝package

``` sh
dotnet add package MyAppLogger
```

在源代碼 `Program.cs` 內引用

``` cs
using AppLogger;

namespace TestMyAppLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var logger = new Logger();
            logger.Log("Hello");
        }
    }
}
```

執行 `dotnet run`, 可以看見輸出 `Hello` 