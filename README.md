# saltoapis-dotnet

This repository contains the source code for the C# SALTO APIs SDK.

> Some of these APIs use gRPC. Refer to the [official gRPC documentation](https://docs.microsoft.com/en-us/aspnet/core/grpc/client?view=aspnetcore-5.0) to learn more about gRPC.


## Authentication Example

The SDK provides a simple mechanism to automatically get and refresh valid access tokens and include them in all gRPC requests:

### Create SaltoCredential

#### Using a key file (available in .NET5.0+)

```csharp
// Create from a service account key file path
var credential = SaltoCredential
  .FromBytes(File.ReadAllBytes("<your-key-file-path>.json"))
  .CreateScoped("https://saltoapis.com/auth/nebula");
```

`SaltoCredential.FromBytes` accepts an optional `HttpClient`.

#### Using a client ID and client secret

Alternatively, you can use a client ID and client secret.

```csharp
// Create from a client ID and client secret
var credential = SaltoCredential
  .FromClientSecret(clientId, clientSecret)
  .CreateScoped("https://saltoapis.com/auth/nebula");
```

`SaltoCredential.FromClientSecret` accepts an optional custom OpenID Connect discovery URI and `HttpClient`.

### Use the credentials to create the gRPC invoker

```csharp
// Use the credentials when creating the gRPC Channel
var callCredentials = SaltoapisCallCredentials.FromTokenProvider(credential);

var channel = GrpcChannel.ForAddress(
  "https://nebula.saltoapis.com",
  new GrpcChannelOptions
  {
    Credentials = ChannelCredentials.Create(new SslCredentials(), callCredentials)
  });

var invoker = channel.CreateCallInvoker();

// Now you can use the resulting invoker to instantiate gRPC services
var service = new UserService.UserServiceClient(invoker);
```

You can find more information about authentication at https://developer.saltosystems.com/nebula/api/authentication/.

## Setup

This SDK publishes NuGet packages in GitHub's Package Registry. You can see all published packages here: https://github.com/saltoapis/saltoapis-dotnet/packages/.

Even though the packages are public, GitHub does not yet support downloading packages anonymously so you will need a GitHub personal access token with the `read:packages` permission set to retrieve the packages. 

To set up your NuGet environment with your access token, do the following:

### 1. Create a personal access token

Access https://github.com/settings/tokens and press "Generate new token". Give the token the name and expiration you want and be sure to check the `read:packages` scope. Then press "Generate token".

You will then have to copy your token because it is going to be shown to you only once.

### 2. Add the GitHub NuGet repository

You have to add the saltoapis NuGet repository (https://nuget.pkg.github.com/saltoapis/index.json) to access the packages. You can do that by manually editing your NuGet.Config file:
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

If everything is set up correctly, you will be able to add dependencies on the packages listed in https://github.com/saltoapis/saltoapis-dotnet/packages?ecosystem=nuget to your project.
