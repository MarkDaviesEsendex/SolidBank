using System;
using SolidBank.Printers;

namespace SolidBank
{
    public interface IAccount
    {
        void Deposit(int amount);
        void Withdraw(int amount);
        string PrintStatement();
    }

    public class Account : IAccount
    {
        private readonly ITransactionLog _transactionLog;
        private readonly IStatementPrinter _statementPrinter;

        public Account(ITransactionLog transactionLog, IStatementPrinter statementPrinter)
        {
            _transactionLog = transactionLog;
            _statementPrinter = statementPrinter;
        }

        public void Deposit(int amount) 
            => _transactionLog.CreateDepositTransaction(DateTime.Now, amount);

        public void Withdraw(int amount)
            => _transactionLog.CreateWithdrawlTransaction(DateTime.Now, amount);

        public string PrintStatement() 
            => _statementPrinter.FromTransactionLog(_transactionLog);
    }
}