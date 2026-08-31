[![](https://img.shields.io/nuget/v/soenneker.ngrok.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.ngrok.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.ngrok.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.ngrok.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.ngrok.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.ngrok.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.ngrok.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.ngrok.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.ngrok.OpenApiClient

Typed request builders and models for calling the ngrok API from .NET.

## Installation

```bash
dotnet add package Soenneker.ngrok.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Ngrok.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);
httpClient.DefaultRequestHeaders.Add("ngrok-version", "2");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new NgrokOpenApiClient(adapter);
var endpoints = await client.Endpoints.GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to `https://api.ngrok.com`. Every request must include the `ngrok-version` header.

For application registration, configuration-based credentials, and managed client reuse, use [`Soenneker.ngrok.OpenApiClientUtil`](https://github.com/soenneker/soenneker.ngrok.openapiclientutil).
