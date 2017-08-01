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
            TempC t1 = new TempC();
            t1.valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite 1 para Farenheit, 2 para Kelvin, 3 para nova temperatura, 0 para sair");
            int comando = int.Parse(Console.ReadLine());

            while (comando != 0)
            {
                if (comando == 1)
                {
                    Console.WriteLine(t1.EmFarenheit());
                }
                else if (comando == 2)
                {
                    Console.WriteLine(t1.EmKelvin());
                }
                else if (comando == 3)
                {
                    t1.valor = Convert.ToDouble(Console.ReadLine());
                }
                else
                    Console.WriteLine("comando invalido");

                Console.WriteLine("Digite 1 para Farenheit, 2 para Kelvin, 3 para nova temperatura, 0 para sair");
                comando = int.Parse(Console.ReadLine());
            }
           


            Console.WriteLine(t1.EmFarenheit());
            Console.WriteLine(t1.EmKelvin());



            

        }
    }
}
