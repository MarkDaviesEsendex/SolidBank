using System;
using System.Collections.Generic;
using SolidBank.Transactions;

namespace SolidBank
{
    public interface ITransactionLog
    {
        bool CreateDepositTransaction(DateTime transactionTime, int amount);
        bool CreateWithdrawlTransaction(DateTime transactionTime, int amount);
    }

    public class TransactionLog : List<Transaction>, ITransactionLog
    {
        public bool CreateDepositTransaction(DateTime transactionTime, int amount)
        {
            return false;
        }

        public bool CreateWithdrawlTransaction(DateTime transactionTime, int amount)
        {
            return false;
        }
    }
}