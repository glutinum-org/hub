@echo off

dotnet tool restore
dotnet run --project build/Glutinum.Hub.Build.fsproj -- %*
