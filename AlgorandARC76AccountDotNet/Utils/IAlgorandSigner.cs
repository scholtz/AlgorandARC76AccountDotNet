namespace AlgorandARC76AccountDotNet.Utils
{
    public interface IAlgorandSigner
    {
        /// <summary>
        /// Sign transactions
        /// </summary>
        /// <param name="txs">List of unsigned transactions</param>
        /// <returns></returns>
        public IEnumerable<Algorand.Algod.Model.Transactions.SignedTransaction> Sign(Algorand.Algod.Model.Transactions.Transaction[] txs);
        /// <summary>
        /// Returns the signing address
        /// </summary>
        /// <returns></returns>
        public Algorand.Address getAddress();
    }
}
