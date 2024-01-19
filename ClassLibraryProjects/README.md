# 建立解決方案

``` sh
mkdir ClassLibraryProjects
dotnet new sln
```

# 建立類別庫專案

``` sh
dotnet new classlib -o StringLibrary
dotnet sln add StringLibrary/StringLibrary.csproj
dotnet build
```

# 將主控台應用程式新增至解決方案

``` sh
dotnet new console -o ShowCase
dotnet sln add ShowCase/ShowCase.csproj
```

# 新增專案參考

``` sh
dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj
```

# 執行應用程式

``` sh
dotnet run --project ShowCase/ShowCase.csproj
```


# 參考文件

- [教學課程：使用 Visual Studio Code 建立 .NET 類別庫](https://learn.microsoft.com/zh-tw/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-8-0)