FROM microsoft/windowsservercore
#ADD /bin/Release/ /

WORKDIR /app
COPY bin/Release/ . 


ENTRYPOINT NetFramework.BackgroundTask.exe 