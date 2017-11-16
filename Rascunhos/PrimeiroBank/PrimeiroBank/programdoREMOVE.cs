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
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = AulaLp; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            Carro c = new Carro();
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


            
            
            Console.WriteLine("Digite 1 para fazer seu cadastro n/ Digite 2 para remover ?");
            int resp = int.Parse(Console.ReadLine());

            if (resp == 1)
            {

            
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

            }
            else if (resp == 2)
            {
                Console.WriteLine("Se quiser remover Id digite 2.1");
                int removeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Se quiser remover Potencia Max digite 2.2");
                int removePotM= int.Parse(Console.ReadLine());
                Console.WriteLine("Se quiser remover Modelo+Cor digite 2.3");
                int removeModC= int.Parse(Console.ReadLine());
                
            }
            else if (resp == 2.1)
            {
                Console.WriteLine("Digite o id que deseja remover");
                int idR = int.Parse(Console.ReadLine());
                comd.CommandText = @"DELETE from Carro
                                    WHERE id = (idR)";
            }
            else if (resp == 2.2)
            {
                Console.WriteLine("Digite a potenciaMaxima que deseja remover");
                int PotmaxR = int.Parse(Console.ReadLine());
                comd.CommandText = @"DELETE from Carro
                                    WHERE id = (PotmaxR)";
            }

            else if (resp == 2.3)
            {
                Console.WriteLine("Digite o modelo e a cor que deseja remover");
                int ModCR = int.Parse(Console.ReadLine());
                comd.CommandText = @"DELETE from Carro
                                    WHERE id = (ModCR)";
            }

            
            

            

            
          

            
        }
    }
}
