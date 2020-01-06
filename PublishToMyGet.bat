@echo off

::create nuget_pub
if not exist nuget_pub (
    md nuget_pub
)

::clear nuget_pub
for /R "nuget_pub" %%s in (*) do (
    del %%s
)

dotnet pack src/Cosmos.I18N.Abstractions -c Release -o nuget_pub
dotnet pack src/Cosmos.I18N.Countries -c Release -o nuget_pub
dotnet pack src/Cosmos.I18N -c Release -o nuget_pub
dotnet pack src/Cosmos.I18N.Adapters.Json -c Release -o nuget_pub
dotnet pack src/Cosmos.I18N.Adapters.Xml -c Release -o nuget_pub
dotnet pack src/Cosmos.I18N.Extensions.Console -c Release -o nuget_pub
dotnet pack src/Cosmos.I18N.Extensions.Autofac -c Release -o nuget_pub
dotnet pack src/Cosmos.I18N.Extensions.DependencyInjection -c Release -o nuget_pub
dotnet pack src/Cosmos.I18N.Extensions.Handlebars -c Release -o nuget_pub
dotnet pack src/Cosmos.Bridges.AbpBridge.I18N -c Release -o nuget_pub

for /R "nuget_pub" %%s in (*symbols.nupkg) do (
    del %%s
)

echo.
echo.

set /p key=input key:
set source=https://www.myget.org/F/alexinea/api/v2/package

for /R "nuget_pub" %%s in (*.nupkg) do ( 
    call nuget push %%s %key% -Source %source%	
	echo.
)

pause