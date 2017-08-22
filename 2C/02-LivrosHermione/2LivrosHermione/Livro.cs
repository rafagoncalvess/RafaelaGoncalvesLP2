using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2LivrosHermione
{
    class Livro
    {
        public string titulo;
        public int qtdpag, DiasAteDev;

        public int TempoDeLeitura(int paghr)
        {
            return qtdpag / paghr;
        }
    }
}
