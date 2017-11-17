using System;
using SolidBank.Printers;
using StructureMap;

namespace SolidBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new Container(config =>
            {
                config.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                });
                config.For<IStatementTemplate>().Add<StandardStatement>();
            });


            var account = container.GetInstance<IAccount>();

            account.Deposit(10);
            account.Deposit(20);
            account.Withdraw(30);
            account.PrintStatement();
            Console.ReadLine();
        }
    }
}
