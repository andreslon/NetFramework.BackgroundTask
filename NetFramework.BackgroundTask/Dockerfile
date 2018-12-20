FROM microsoft/windowsservercore
#FROM microsoft/dotnet-framework:4.7
#ADD /bin/Release/ /

WORKDIR /app
COPY bin/Release/ . 


ENTRYPOINT NetFramework.BackgroundTask.exe 