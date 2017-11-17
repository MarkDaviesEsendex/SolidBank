namespace SolidBank.Appenders
{
    public class BalanceAppender
    {
        public string AppendBalance(string statement, int balance) 
            => $"{statement}|{balance}|";
    }
}