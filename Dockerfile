FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /app
COPY /app /app
CMD ASPNETCORE_URLS=http://*:$PORT dotnet NsccCourseMap_Neo.dll