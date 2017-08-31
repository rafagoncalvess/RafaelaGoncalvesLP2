using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine(" Deseja qual conversão? \n !- kilograma para grama \n 2- celsius para kelvin \n 3-metros para kilometros\n 4- celsius para fahrenheit \n 5-grama pra kilo \n 6- kilometro para milha ");
            
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Conversor.KgParaG(n));

            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Conversor.CParaK(m));

            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Conversor.MParaKm(l));

            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Conversor.CParaFh(f));

            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Conversor.GParaKg(g));

            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Conversor.KmParaMil(h));
        }


    }
}
