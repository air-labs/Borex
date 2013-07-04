using Borex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new BorexServer();
            var rates = server.Rates;
            for (int i = 0; i < rates.Count; i++)
                Console.WriteLine("{0,-6}{1,8:0.00}{2,8:0.00}",
                    rates[i].Currency,
                    rates[i].Cost,
                    rates[i].Growth);
            Console.ReadKey();

        }
    }
}
