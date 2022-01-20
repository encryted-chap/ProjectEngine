cd engine
dotnet publish -r win-x64 /p:IncludeNativeLibrariesForSelfExtract=true --self-contained true
cd ..
cp ./engine/bin/Debug/net5.0/engine.dll ./project/deps/engine.dll