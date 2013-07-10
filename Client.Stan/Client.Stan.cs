using Borex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Stan
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account[Currencies.USD] = account[Currencies.EUR] =
                account[Currencies.PLN] = account[Currencies.CZK] = 100;
            var server = new BorexServer();
        }
    }
}
