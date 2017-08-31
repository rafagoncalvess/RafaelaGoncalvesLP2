using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Console.WriteLine("1 - Base e altura 2 - Lei dos Cossenos");
            int comando = int.Parse(Console.ReadLine());

            if (comando == 1)
            {
                Console.WriteLine("Informe a base e a altura");
                double b = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(t.Area(b, h));
            }
            else if (comando == 2)
            {
                Console.WriteLine("Informe os lados e o cosseno do ângulo");
                double l1 = Convert.ToDouble(Console.ReadLine());
                double l2 = Convert.ToDouble(Console.ReadLine());
                double co = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(t.Area(l1, l2, co));
            }

        }
    }
}
