using System;

namespace SolidBank.Transactions
{
    public  abstract class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public int Amount { get; set; }

        public abstract string PrintTransaction();
    }
}