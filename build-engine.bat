cd engine
dotnet publish --self-contained
cd ..
cp ./engine/bin/Debug/net5.0/engine.dll ./project/deps/engine.dll