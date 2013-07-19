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

        public static Account CreateAccount(double usd, double eur, double pln, double czk)
        {
            var account = new Account();
            account[Currencies.USD] = usd;
            account[Currencies.EUR] = eur;
            account[Currencies.PLN] = pln;
            account[Currencies.CZK] = czk;
            return account;
        }

        static void Main(string[] args)
        {
            var account = new AccountSet();
            account[Currencies.USD] = account[Currencies.EUR] =
                account[Currencies.PLN] = account[Currencies.CZK] = 100;
            var server = new BorexServer();

            var currencies = server
                                    .Rates
                                    .OrderBy(z => -z.RelativeGrowth)
                                    .Select(z => z.Currency)
                    				.GetFirstAndLast();

            server.Exchange(account, currencies.Item1, currencies.Item2, 100);
        }
    }
}
