using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrimeiroBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("insira modelo");
            c.Modelo = Console.ReadLine();
            Console.WriteLine("insira cor");
            c.Cor = Console.ReadLine();
            Console.WriteLine("insira placa");
            c.Placa = Console.ReadLine();
            Console.WriteLine("insira marca");
            c.Marca = Console.ReadLine();
            Console.WriteLine("insira potencia");
            c.Potencia = Convert.ToInt32(Console.ReadLine());

            
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = AulaLp; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();

            comd.Connection = conex;
            comd.CommandText = c.Registro();
            comd.Parameters.AddWithValue("Marca", c.Marca);
            comd.Parameters.AddWithValue("Modelo", c.Modelo);
            comd.Parameters.AddWithValue("Cor", c.Cor);
            comd.Parameters.AddWithValue("Placa", c.Placa);
            comd.Parameters.AddWithValue("Potencia", c.Potencia);


            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();



            Console.WriteLine("OK");
        }
    }
}
