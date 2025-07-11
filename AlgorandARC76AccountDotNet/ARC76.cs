﻿using Nethereum.Signer;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace AlgorandARC76AccountDotNet
{
    public class ARC76
    {
        const int HASH_SIZE = 32;

        public static Algorand.Algod.Model.Account GetAccount(string password, int slot = 0)
        {
            byte[] salt = Encoding.ASCII.GetBytes($"ARC-0076-{slot}-PBKDF2-999999");
            byte[] input = Encoding.UTF8.GetBytes($"ARC-0076-{password}-{slot}-PBKDF2-999999");
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new(input, salt, 999999, System.Security.Cryptography.HashAlgorithmName.SHA256);
            var seed = pbkdf2.GetBytes(HASH_SIZE);
            return new Algorand.Algod.Model.Account(seed);
        }
        public static Algorand.Algod.Model.Account GetEmailAccount(string email, string password, int slot = 0)
        {
            byte[] salt = Encoding.ASCII.GetBytes($"ARC-0076-{email}-{slot}-PBKDF2-999999");
            byte[] input = Encoding.UTF8.GetBytes($"ARC-0076-{email}-{password}-{slot}-PBKDF2-999999");
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new(input, salt, 999999, System.Security.Cryptography.HashAlgorithmName.SHA256);
            
            var seed = pbkdf2.GetBytes(HASH_SIZE);
            return new Algorand.Algod.Model.Account(seed);
        }
        public static EthECKey GetEVMAccount(string password, int slot = 0)
        {
            byte[] salt = Encoding.ASCII.GetBytes($"ARC-0076-{slot}-PBKDF2-999999");
            byte[] input = Encoding.UTF8.GetBytes($"ARC-0076-{password}-{slot}-PBKDF2-999999");
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new(input, salt, 999999, System.Security.Cryptography.HashAlgorithmName.SHA256);
            var seed = pbkdf2.GetBytes(HASH_SIZE);
            return new EthECKey(seed,true, 0);
        }
        public static EthECKey GetEVMEmailAccount(string email, string password, int slot = 0)
        {
            byte[] salt = Encoding.ASCII.GetBytes($"ARC-0076-{email}-{slot}-PBKDF2-999999");
            byte[] input = Encoding.UTF8.GetBytes($"ARC-0076-{email}-{password}-{slot}-PBKDF2-999999");
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new(input, salt, 999999, System.Security.Cryptography.HashAlgorithmName.SHA256);

            var seed = pbkdf2.GetBytes(HASH_SIZE); 
            return new EthECKey(seed, true, 0);
        }
    }
}