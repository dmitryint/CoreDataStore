FROM microsoft/dotnet:latest
MAINTAINER Stuart Shay

# Set environment variables
ENV ASPNETCORE_URLS="http://*:5000"
ENV ASPNETCORE_ENVIRONMENT="Staging"
ENV CONNECTION_PostgreSQL="User ID=nyclandmarks;Password=nyclandmarks;Server=database;Port=5432;Database=nyclandmarks;Integrated Security=true;Pooling=true;"

# Open up port
EXPOSE 5000

RUN apt-get install curl -y
RUN curl -sL https://deb.nodesource.com/setup_6.x | bash -
RUN apt-get install -y nodejs
RUN npm install -g npm@3

COPY src /app

WORKDIR /app

RUN dotnet restore

WORKDIR /app/CoreDataStore.Web
RUN npm install
RUN npm run clean
RUN npm run build
RUN dotnet build

ENTRYPOINT ["dotnet", "run"]