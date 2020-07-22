rm -r build
mkdir build
dotnet build -c Release .\src\Compilers\Server\VBCSCompiler\VBCSCompiler.csproj
dotnet build -c Release .\src\Compilers\CSharp\csc\csc.csproj
Copy-Item artifacts\bin\VBCSCompiler\Release -Destination build -Recurse
Copy-Item artifacts\bin\csc\Release -Destination build -Recurse -Force