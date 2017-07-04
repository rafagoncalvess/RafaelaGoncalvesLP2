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
            int A, B, C, D, E, bemMarcado = 0, ambiguo = 0, i;
            string resp = "*";

            Console.WriteLine("Informe a qtd de questoes");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o tom da letra");
                A = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tom da letra");
                B = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tom da letra");
                C = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tom da letra");
                D = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tom da letra");
                E = int.Parse(Console.ReadLine());

                if (A <= 100)
                {
                    resp = "A";
                    bemMarcado++;

                }
                else if (A > 100 && A < 155)
                {
                    ambiguo++;
                }
                if (B <= 100)
                {
                    resp = "B";
                    bemMarcado++;

                }
                else if (B > 100 && B < 155)
                {
                    ambiguo++;
                }
                if (C <= 100)
                {
                    resp = "C";
                    bemMarcado++;

                }
                else if (C > 100 && C < 155)
                {
                    ambiguo++;
                }
                if (D <= 155)
                {
                    resp = "D";
                    bemMarcado++;

                }
                else if (D > 100 && D < 155)
                {
                    ambiguo++;
                }
                if (E <= 100)
                {
                    resp = "E";
                    bemMarcado++;

                }
                else if (E > 100 && E < 155)
                {
                    ambiguo++;
                }
                if (bemMarcado == 1 && ambiguo == 0)
                    Console.WriteLine(resp);
                else
                    Console.WriteLine("*");
            }
        }
    }
}
