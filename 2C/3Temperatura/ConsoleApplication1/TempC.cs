using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TempC
    {
        public double valor;

        public double EmFarenheit()
        {
            double f = 1.8 * valor + 32;
            return f;
        }
        public double EmKelvin()
        {
            double k = valor + 273;
            return k;
        }
    }
}
