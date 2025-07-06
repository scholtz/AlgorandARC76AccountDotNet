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

# EVM ARC76 Account support

```
var account = AlgorandARC76AccountDotNet.ARC76.GetEVMAccount("12345678901234567890123456789012345678901234567890");
Assert.That(account.GetPublicAddress(), Is.EqualTo("0x6fD4983EaC3F958d1BF2009be4FCc0E8792A8AC6"));
Assert.That(account.GetPrivateKey(), Is.EqualTo("0x9365ff3d966fdb3b8765e27007677440e67382ed4503c2d00a39638548e13c22"));
```


```
var account = AlgorandARC76AccountDotNet.ARC76.GetEVMEmailAccount("email@example.com", "12345678901234567890123456789012345678901234567890");
Assert.That(account.GetPublicAddress(), Is.EqualTo("0x0b6CEF2E7844F27019Fce92205F5FedF684c6926"));
Assert.That(account.GetPrivateKey(), Is.EqualTo("0xe1078b9af5d2b58abc819135f6b8f358a3a36dd04d4707eb51f481d766a86915"));
```