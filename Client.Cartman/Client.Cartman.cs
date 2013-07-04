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
            foreach(var e in server.Rates)
                Console.WriteLine("{0,-6}{1,8:0.00}{2,8:0.00}",
                    e.Currency,
                    e.Cost,
                    e.Growth);
            Console.ReadKey();

        }
    }
}
