using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borex
{
    public class BorexServer
    {
        List<Rate> rates = new List<Rate>
        {
            new Rate(Currencies.USD, 32, 2),
            new Rate(Currencies.EUR, 44, -3),
            new Rate(Currencies.CZK, 1.6, -0.2),
            new Rate(Currencies.PLN, 11, 1)
        };

        public List<Rate> Rates { get { return rates; } }

    }
}
