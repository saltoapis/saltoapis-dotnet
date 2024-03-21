# saltoapis-dotnet

This repository contains the source code for the C# SALTO APIs SDK.

> Some of these APIs are using gRPC. Refer to the [official gRPC documentation](https://docs.microsoft.com/en-us/aspnet/core/grpc/client?view=aspnetcore-5.0) to learn more about gRPC.

## Quick Start

This SDK publishes NuGet packages in GitHub's Package Registry. You can see all published packages here: https://github.com/saltoapis/saltoapis-dotnet/packages/.

Even though the packages are public, GitHub does not yet support downloading packages anonymously so you will need a GitHub personal access token with the `read:packages` permission set to retrieve the packages. 

To setup your NuGet environment with your access token do the following:

### 1. Create a personal access token

Access https://github.com/settings/tokens and press "Generate new token". Give the token the name and expiration you want and be sure to check the `read:packages` scope. Then press "Generate token".

You will then have to copy your token (because its going to be shown to you only once).

### 2. Add the GitHub NuGet repository

You have to add the saltoapis NuGet repository (https://nuget.pkg.github.com/saltoapis/index.json) to access the packages. You can do that manually editting your NuGet.Config file:
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    ...
    <add key="saltoapis" value="https://nuget.pkg.github.com/saltoapis/index.json" />
  </packageSources>

  <packageSourceCredentials>
    <saltoapis>
        <add key="Username" value="{{GITHUB_USERNAME}}" />
        <add key="ClearTextPassword" value="{{PERSONAL_ACCESS_TOKEN}}" />
    </saltoapis>
  </packageSourceCredentials>

</configuration>
```

Or by using an IDE. In Rider you can open the NuGet panel and in the "Sources" tab add the new sources you want. It will show you a modal where you will have to set the following:
- Name: saltoapis
- URL: https://nuget.pkg.github.com/saltoapis/index.json
- User: *`{{GITHUB_USERNAME}}`*
- Password: *`{{PERSONAL_ACCESS_TOKEN}}`*

### 3. Use the packages

If everything is setup correctly you will be able to include dependencies to the packages listed in https://github.com/saltoapis/saltoapis-dotnet/packages?ecosystem=nuget in your project.

> [!NOTE]
> You will also need to add the gRPC client implementation you want to use.
> saltoapis-dotnet supports both official gRPC client implementations: `Grpc.Core` (based on the gRPC C core native library) and `Grpc.Net.Client` (written purely in C#, usually referred as "grpc-dotnet").
>
> `Grpc.Core` is going to be deprecated soon (see [blogpost](https://grpc.io/blog/grpc-csharp-future/) for more details), so we recommend using `Grpc.Net.Client` but you can choose which ever suits you best.

## Authentication example (using Grpc.Net.Client)

The SDK provides a simple gRPC interceptor that will automatically get and refresh valid access tokens and include them in all gRPC requests:
```c#
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using Saltoapis.Auth;
using Saltoapis.Nebula.User.V1;

// create a gRPC channel
GrpcChannel channel = GrpcChannel.ForAddress("https://nebula.saltoapis.com");

// Create a new SaltoapisAuthInterceptor with your user credentials
var authInterceptor = new SaltoapisAuthInterceptor(clientID, clientSecret);

// And add the interceptor to your channel
var invoker = ChannelExtensions.Intercept(channel, authInterceptor);

// Now you can use the resulting invoker to instantiate gRPC services
var service = new UserService.UserServiceClient(invoker);
```

You can find more information about authentication at https://developer.saltosystems.com/nebula/api/authentication/.
