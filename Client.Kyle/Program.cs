using Borex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Kyle
{
    class Program
    {

        public static AccountSet CreateAccount(double usd, double eur, double pln, double czk)
        {
            var account = new AccountSet();
            account[Currencies.USD] = usd;
            account[Currencies.EUR] = eur;
            account[Currencies.PLN] = pln;
            account[Currencies.CZK] = czk;
            return account;
        }

        static void Main(string[] args)
        {
            var account = CreateAccount(100, 100, 100, 100);

            var server = new BorexServer();

            var currencies = server
                                    .Rates
                                    .OrderBy(z => -z.RelativeGrowth)
                                    .Select(z => z.Currency)
                    				.GetFirstAndLast();

            server.Convert(account, currencies.Item1, currencies.Item2, 100);
        }
    }
}
