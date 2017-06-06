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
            int i, n;

            Console.WriteLine("Informe quantos competidores há");
            n = Convert.ToInt32(Console.ReadLine());

            Competidor[] competidores = new Competidor[n];

            for (i = 0; i <= n; i++)
            {
             Competidor corredor = new Competidor(); // Cria um objeto Competidor (Instanciação). Instância = objeto.

             Console.WriteLine("Informe o nome");
             corredor.nome = Console.ReadLine();

             Console.WriteLine("Informe o t1");
             t1 = Convert.ToDouble(Console.ReadLine());
             corredor.t1 = t1;
             Console.WriteLine("Informe o t2");
             t2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Informe o t3");
             t3 = Convert.ToDouble(Console.ReadLine());

             competidores[i] = corredor;
            }

            Console.ReadKey();

            

        }
    }
}
