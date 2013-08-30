using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borex
{
    public class BorexServer
    {
        public List<Rate> GetHistory(Currencies currency)
        {
            var history = new List<Rate>();
            for (int i = 0; i < 50; i++)
                history.Add(new Rate(currency, i, 1));
            return history;
        }

        List<Rate> rates = new List<Rate>
        {
            new Rate(Currencies.USD, 32, 2),
            new Rate(Currencies.EUR, 44, -3),
            new Rate(Currencies.CZK, 1.6, -0.2),
            new Rate(Currencies.PLN, 11, 1)
        };

        public IEnumerable<Rate> Rates
        {
            get
            {
                foreach (var e in rates) yield return e;
            }
        }

        public void Convert(AccountSet account, Currencies from, Currencies to, double amount)
        {
            if (account[from] < amount) throw new ArgumentException();
            Console.WriteLine("{0} {1} is exchanged to {2}", amount, from, to);
            account[from] -= amount;
            amount *= Rates.Where(z => z.Currency == from).FirstOrDefault().Cost;
            amount *=0.95;
            amount /= Rates.Where(z => z.Currency == to).FirstOrDefault().Cost;
            account[to] += amount;
        }

    }
}
