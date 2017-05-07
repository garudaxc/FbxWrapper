del .\adapter\*.cs /f
swig -c++ -csharp -namespace Fbx -I"header" -outdir adapter -o FbxWrapperDll\wrapper_gen.cpp fbxwapper.i
pause