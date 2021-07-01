using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabTransporte.Controlador
{
    public class Conexao
    {
        public static NpgsqlConnection GetConexao()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=dt_transporte");
                conexao.Open();
            }catch(NpgsqlException erro)
            {
                Console.WriteLine("Erro de conexão: " + erro.Message);
            }
            return conexao;
        }
    }
}
