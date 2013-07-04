using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borex
{
    public class Account
    {
        double[] values = new double[10];
        public double this[Currencies currency]
        {
            get { return values[(int)currency]; }
            set { values[(int)currency] = value; }
        }
    }
}
