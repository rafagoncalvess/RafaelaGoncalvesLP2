using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.MySqlClient; 

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao = new MySqlConnection ("Server=localhost; Database=escola; Uid=root; Pwd=")
            MySqlCommand cmd = new MySqlCommand();
           
            cmd.Connection = conexao;
            cmd.CommandText ="Insert into (nome,siape,salario)('pedro','123789',20000)";

            conexao.Open();
            cmd.ExecuteNonQuery();
            conexao.Close();

            

            string nome = "Francisco";

            Console.WriteLine("ok");

        }

    }
}
