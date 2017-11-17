namespace SolidBank.Printers
{
    public interface IStatementTemplate
    {
        string PrintHeader();
        string PrintBody();
    }

    public abstract class StatementTemplate : IStatementTemplate
    {
        public abstract string PrintHeader();
        public abstract string PrintBody();
    }
}