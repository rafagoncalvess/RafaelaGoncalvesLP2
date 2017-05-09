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
            string modelo, t1, p1;
            double km, potencia;

            Console.WriteLine("Qual o modelo do veiculo?");
            modelo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Qual a potência do veículo?");
            potencia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a quilometragem do veículo?");
            km = Convert.ToDouble(Console.ReadLine());

            if (km <= 5000)
            {
                Console.WriteLine("veículo é novo");
            }
            else if (km > 5000 && km <30000)
            {
                Console.WriteLine("veículo é semi novo");
            }
            else 
            {
                Console.WriteLine("veículo é velho");
            }
            if (potencia > 120 && potencia <= 200)
            {
                Console.WriteLine("veículo é forte");
            }
            else if (potencia > 200)
            {
                Console.WriteLine("veículo é potente");
            }
            else
            {
                Console.WriteLine("veículo é popular");
            }

            Console.ReadKey();

        }
    }
}
