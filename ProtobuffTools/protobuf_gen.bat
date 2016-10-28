cd /d %~dp0
if not exist gen md gen
cd pb-common
for /r . %%i in (*.proto) do ..\protobuf-net-r668\ProtoGen\protogen.exe -i:%%i -o:../gen/%%~ni.cs