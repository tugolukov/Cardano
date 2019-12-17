# Cardano library

Unofficial library for using Cardano platform in .NET projects.

## How to install with Nuget?
- [Cardano.Abstractions](https://www.nuget.org/packages/Cardano.Abstractions/ "Cardano.Abstractions")
- [Cardano.Core](https://www.nuget.org/packages/Cardano.Core/ "Cardano.Core")
- [Cardano.Entities](https://www.nuget.org/packages/Cardano.Entities/ "Cardano.Entities")
- [Cardano.Utils](https://www.nuget.org/packages/Cardano.Utils/ "Cardano.Utils")

## Example using in ASP.NET Core apps
Add to ConfigureServices method:
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Other methods
    
    services.AddCardanoCore(options => options.Url = "http://localhost:8080");

    // Other methods
}

```

## Example using in other .NET apps
Add to your methods:
```csharp
var connectionOptions = new ConnectionOptions()
{
    Url = "http://localhost:8080"
};
var accountsService = new AccountsService(connectionOptions);

var result = await accountsService.GetAll(new AccountsContext()
{
    WalletId = "J7rQqaLLHBFPrgJXwpktaMB1B1kQBXAyc2uRSfRPzNVGiv6TdxBzkPNBUWysZZZdhFG9gRy3sQFfX5wfpLbi4XTFGFxTg",
    Page = 1,
    PerPage = 50
});
```

Instead of `AccountService` you can use other services:
- `AddressesService`
- `InformationsService`
- `InternalService`
- `SettingsService`
- `TransactionsService`
- `WalletsService`

## Service description
- **Cardano.Abstractions**
This project contains interfaces, the implementation of which you can develop youself, and models of contexts for interfaces.

- **Cardano.Core**
This project contains implemetation of all interfaces. If you want use full functionallity, you need this project.

- **Cardano.Entities**
This project contains all models that are used in **Cardano.Core**.

- **Cardano.Utils**
This project contains additional functionallity for HttpClient and models for Response.

## Official Cardano Documentation
- API: https://cardanodocs.com/technical/wallet/api/v1/
- Cardano: https://www.cardano.org/en/home/
