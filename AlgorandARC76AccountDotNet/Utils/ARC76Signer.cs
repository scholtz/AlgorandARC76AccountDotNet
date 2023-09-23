using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AlgorandARC76AccountDotNet.Model.Config;
using Microsoft.Extensions.Options;

namespace AlgorandARC76AccountDotNet.Utils
{
    public class ARC76Signer : IAlgorandSigner
    {
        private readonly Account k;
        /// <summary>
        /// Constructor for ARC76 signer
        /// </summary>
        /// <param name="arc76Config"></param>
        /// <exception cref="Exception"></exception>
        public ARC76Signer(IOptionsMonitor<AlgorandARC76AccountDotNet.Model.Config.ARC76Config> arc76Config)
        {
            if (string.IsNullOrEmpty(arc76Config.CurrentValue.Data))
            {
                throw new Exception("Please configure ARC76:Data");
            }
            k = ARC76.GetAccount(arc76Config.CurrentValue.Data);
        }

        public Algorand.Address getAddress()
        {
            return k.Address;
        }

        /// <summary>
        /// Sign txs with ARC76 account
        /// </summary>
        /// <param name="txs"></param>
        /// <returns></returns>
        public IEnumerable<SignedTransaction> Sign(Transaction[] txs)
        {
            return txs.Select(tx => tx.Sign(k));
        }
    }
}