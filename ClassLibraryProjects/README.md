# 使用 Visual Studio Code 建立 .NET 類別庫
## 建立解決方案

``` sh
mkdir ClassLibraryProjects
dotnet new sln
```

## 建立類別庫專案

``` sh
dotnet new classlib -o StringLibrary
dotnet sln add StringLibrary/StringLibrary.csproj
dotnet build
```

## 將主控台應用程式新增至解決方案

``` sh
dotnet new console -o ShowCase
dotnet sln add ShowCase/ShowCase.csproj
```

## 新增專案參考

``` sh
dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj
```

## 執行應用程式

``` sh
dotnet run --project ShowCase/ShowCase.csproj
```

# 使用 Visual Studio Code 測試 .NET 類別庫

## 建立單元測試專案

開啟解決方案 `ClassLibraryProjects` 並建立名為 「StringLibraryTest」 的單元測試專案

``` sh
dotnet new mstest -o StringLibraryTest
```

將測試專案新增至方案。

``` sh
dotnet sln add StringLibraryTest/StringLibraryTest.csproj
```

## 新增專案參考

``` sh
dotnet add StringLibraryTest/StringLibraryTest.csproj reference StringLibrary/StringLibrary.csproj
```

## 新增和執行單元測試方法

修改 `UnitTest1.cs` 檔案

執行測試

``` sh
dotnet test StringLibraryTest/StringLibraryTest.csproj
```

# 參考文件

- [教學課程：使用 Visual Studio Code 建立 .NET 類別庫](https://learn.microsoft.com/zh-tw/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-8-0)
- [教學課程：使用 Visual Studio Code 測試 .NET 類別庫](https://learn.microsoft.com/zh-tw/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-8-0)