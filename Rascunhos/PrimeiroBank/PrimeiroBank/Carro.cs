using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroBank
{
    class Carro
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public int Potencia { get; set; }


        public string Registro()
        {
            return string.Format(@"INSERT 
                                 INTO CARRO(marca,modelo,cor,placa,potencia)
                                 VALUES ('{0}', '{1}', '{2}', '{3}', {4});", @Marca, @Modelo, @Cor, @Placa, @Potencia);
        }
    }
}
