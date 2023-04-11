### BUILD
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /source

# Prerequisites
COPY utils/* utils/
RUN utils/install-all-prereqs.sh

# Copy csproj and restore as distinct layers
# ... sources
COPY src/RetroTime.Application/*.csproj src/RetroTime.Application/
COPY src/RetroTime.Common/*.csproj src/RetroTime.Common/
COPY src/RetroTime.Domain/*.csproj src/RetroTime.Domain/
COPY src/RetroTime.Infrastructure/*.csproj src/RetroTime.Infrastructure/
COPY src/RetroTime.Persistence/*.csproj src/RetroTime.Persistence/
COPY src/RetroTime.Web/*.csproj src/RetroTime.Web/
COPY src/*.props src/

# # ... tests
# COPY tests/RetroTime.Application.Tests.Unit/*.csproj tests/RetroTime.Application.Tests.Unit/
# COPY tests/RetroTime.Domain.Tests.Unit/*.csproj tests/RetroTime.Domain.Tests.Unit/
# COPY tests/RetroTime.Web.Tests.Unit/*.csproj tests/RetroTime.Web.Tests.Unit/
# COPY tests/RetroTime.Web.Tests.Integration/*.csproj tests/RetroTime.Web.Tests.Integration/
# COPY tests/*.props tests/

COPY *.sln .
COPY *.props .
COPY dotnet-tools.json .
RUN dotnet restore
RUN dotnet tool restore

# Yarn (although it isn't as large, still worth caching)
#COPY package.json src/RetroTime.Web/
#COPY yarn.lock src/RetroTime.Web/
RUN yarn --cwd src/RetroTime.Web/

## Skip build script pre-warm
## This causes later invocations of the build script to fail with "Failed to uninstall tool package 'cake.tool': Invalid cross-device link"
#COPY build.* .
#RUN ./build.sh --target=restore-node-packages

### TEST
FROM build-env AS test

# # ... run tests
# COPY . .
# ENV RETURN_TEST_WAIT_TIME 30
# ENV SCREENSHOT_TEST_FAILURE_TOLERANCE True
# RUN ./build.sh --target=test

### PUBLISHING
FROM build-env AS publish

# ... run publish
COPY . .
RUN ./build.sh --target=Publish-Ubuntu-22.04-x64 --publish-dir=publish --verbosity=verbose --skip-compression=true

### RUNTIME IMAGE
FROM mcr.microsoft.com/dotnet/runtime-deps:6.0
WORKDIR /app

# ... Run libgdi install
COPY utils/install-app-prereqs.sh utils/
RUN bash utils/install-app-prereqs.sh

# ... Copy published app
COPY --from=publish /source/publish/ubuntu.22.04-x64/ .

ENV ASPNETCORE_ENVIRONMENT Production

# Config directory
VOLUME ["/etc/retrotime"]

# Set some defaults for a "direct run" experience
ENV DATABASE__DATABASE "/app/data.db"
ENV DATABASE__DATABASEPROVIDER Sqlite

# ... enable proxy mode
ENV SECURITY__ENABLEPROXYMODE True

# ... health check
HEALTHCHECK CMD curl --fail http://localhost/health || exit

ENTRYPOINT [ "./launch", "run" ]