# Algorand ARC76 Account

.NET implementation of [Algorand ARC76 Account Standard](https://github.com/algorandfoundation/ARCs/blob/main/ARCs/arc-0076.md)

[Nuget link](https://www.nuget.org/packages/AlgorandARC76Account/1.0.0#readme-body-tab)

## Usage

Please tell your users to use length of the password at least 50 chars long for best safety.

### Install nuget

```
dotnet add package AlgorandARC76Account
```

### Password account

```c#
Algorand.Algod.Model.Account account = AlgorandARC76AccountDotNet.ARC76.GetAccount("12345678901234567890123456789012345678901234567890");
```

### Email password account

```c#
Algorand.Algod.Model.Account account = AlgorandARC76AccountDotNet.ARC76.GetEmailAccount("email@example.com", "12345678901234567890123456789012345678901234567890");
```

## ARC76Signer

Configure your web api project with ARC76 signer configuration and the signer can sign transactions whenever it is required.

### Usage

Startup.cs:
```
builder.Services.Configure<AlgorandARC76AccountDotNet.Model.Config.ARC76Config>(builder.Configuration.GetSection("ARC76Config"));
builder.Services.AddSingleton<AlgorandARC76AccountDotNet.Utils.ARC76Signer>();
```

MyController.cs

```
MyController(AlgorandARC76AccountDotNet.Utils.ARC76Signer signer ....){}

void DoSomeAction(){
...
var signed = signer.Sign(new Transaction[] { tx1, tx2 });
...
}
```