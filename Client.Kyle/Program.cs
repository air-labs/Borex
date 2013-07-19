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
                                    .ToArray();
            server.Convert(account, currencies.First(), currencies.Last(), 100);
        }
    }
}
