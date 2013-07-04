using Borex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Butters
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account[Currencies.USD] = 100;
            var server = new BorexServer();
            server.Exchange(account, Currencies.USD, Currencies.EUR, 50);
            foreach (Currencies e in Enum.GetValues(typeof(Currencies)))
                Console.WriteLine("{0,-7}{1:0.00}", e, account[e]);
            Console.ReadKey();
        }
    }
}
