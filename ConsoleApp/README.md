# 創建 ConsoleApp

1. `mkdir ConsoleApp`
2. `dotnet new sln`

# 建立 MyMathLibrary

1. `dotnet new classlib -o MyMathLibrary`
2. `dotnet sln add MyMathLibrary/MyMathLibrary.csproj`

# 修改 MyMathLibrary 內程式碼並建置

1. `cd MyMathLibrary`
2. `dotnet build`

# 建立 MyProgram 主程式

1. `cd ..`
2. `dotnet add MyProgram/MyProgram.csproj reference MyMathLibrary/MyMathLibrary.csproj`
2. `dotnet new console -o MyProgram`

# 修改 MyProgram 主程式

`dotnet run --project MyProgram/MyProgram.csproj`