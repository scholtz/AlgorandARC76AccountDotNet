# Algorand ARC76 Account

.NET implementation of [Algorand ARC76 Account Standard](https://github.com/algorandfoundation/ARCs/blob/main/ARCs/arc-0076.md)

## Usage

Please tell your users to use length of the password at least 50 chars long for best safety.

### Password account

```
Algorand.Algod.Model.Account account = AlgorandARC76AccountDotNet.ARC76.GetAccount("12345678901234567890123456789012345678901234567890");

```

### Email password account

```
Algorand.Algod.Model.Account account = AlgorandARC76AccountDotNet.ARC76.GetEmailAccount("email@example.com", "12345678901234567890123456789012345678901234567890");

```