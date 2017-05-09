using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char pos;
            int i, vogal;
            
            vogal = 0;

            Console.WriteLine("qual?");
            s = Console.ReadLine();
            
            for (i = 0 ; i < s.Length ; i++)
            {
                pos = s[i];

                if (pos == 'a' || pos == 'A')
                vogal++;

                else if (pos == 'e'  || pos == 'E')
                vogal++;

                else if (pos == 'i' ||  pos == 'I')
                vogal++;

                else if (pos == 'o' ||  pos == 'O')
                vogal++;

                else if (pos == 'u' ||  pos == 'U')
                vogal++;

               Console.WriteLine("São {0}", vogal);
            }
            

        }
    }
}