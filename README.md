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