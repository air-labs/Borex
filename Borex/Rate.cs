using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borex
{
    public class Rate
    {
        public readonly Currencies Currency;
        public readonly double Cost;
        public readonly double Growth;

        public double RelativeGrowth { get { return Growth / Cost; } }

        public Rate(Currencies currency, double cost, double growth)
        {
            Currency = currency;
            Cost = cost;
            Growth = growth;
        }
    }
}
