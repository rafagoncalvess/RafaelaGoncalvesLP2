using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Competidor
    { 
        public string nome;
        public double t1;
        public double t2;
        public double t3;

        public double tempoOficial()
        {
            if (t1 > t2 && t1 > t3)
                return t2 + t3;
            else if (t2 > t1 && t2 > t3)
                return t1 + t3;
            else if (t3 > t2 && t3 > t1)
                return t2 + t1;
        }
    }
}
