dotnet new sln --name Projecto3
dotnet new mvc --name App1.Web --auth Individual
dotnet sln add .\App1.Web\App1.Web.csproj
cd .\App1.Web
dotnet add package Microsoft.AspNetCore.Identity
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools