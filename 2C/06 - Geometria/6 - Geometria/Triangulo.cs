using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Geometria
{
    class Triangulo
    {
        
        public double A { get; set; }

        public double Area (double b, double h)
        {
            A = (b * h) / 2;
            return A; 
         }
        public double Area (double a, double b, double c)
        {
            A = (a * a) + (b * b) - 2 * a * b * c;
            return A; 
        }
    }
}
