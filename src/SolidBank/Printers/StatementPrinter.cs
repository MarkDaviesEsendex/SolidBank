using System.Text;

namespace SolidBank.Printers
{
    public interface IStatementPrinter
    {
        string FromTransactionLog(ITransactionLog transactionLog);
    }

    public class StatementPrinter : IStatementPrinter
    {
        private readonly IStatementTemplate _statementTemplate;

        public StatementPrinter(IStatementTemplate statementTemplate)
        {
            _statementTemplate = statementTemplate;
        }

        public string FromTransactionLog(ITransactionLog transactionLog)
            => new StringBuilder().AppendLine(_statementTemplate.PrintHeader())
                .AppendLine(_statementTemplate.PrintBody()).ToString();
    }


}