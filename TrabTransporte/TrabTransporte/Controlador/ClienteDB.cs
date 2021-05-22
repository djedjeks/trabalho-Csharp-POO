using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabTransporte.Modelo;

namespace TrabTransporte.Controlador
{
    class ClienteDB
    {
        public static List<Cliente> getClientes()
        {
            List<Cliente> Clientes = new List<Cliente>();

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM Cliente", conexao);
                NpgsqlDataReader data = select.ExecuteReader();

                while (data.Read())
                {
                    Clientes.Add(
                        new Cliente((int) data["id"], data["nome_completo"].ToString(), data["cpf"].ToString(), DateTime.Parse(data["data_nascimento"].ToString()), char.Parse(data["sexo"].ToString()), data["cidade"].ToString(), data["estado"].ToString()));
                }
                data.Close();
                conexao.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return Clientes;
        }

        public static bool setIncluiCliente(Cliente Cliente)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO Cliente (NOME_COMPLETO, CPF, DATA_NASCIMENTO, SEXO, CIDADE, ESTADO) VALUES (@nomeCompleto, @cpf, @dataNascimento, @sexo, @cidade, @estado)", conexao);
                cmd.Parameters.Add("@nomeCompleto", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Cliente.nome_completo;
                cmd.Parameters.Add("@cpf", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Cliente.cpf;
                cmd.Parameters.Add("@dataNascimento", NpgsqlTypes.NpgsqlDbType.Date).Value = Cliente.data_nascimento;
                cmd.Parameters.Add("@sexo", NpgsqlTypes.NpgsqlDbType.Char).Value = Cliente.sexo;
                cmd.Parameters.Add("@cidade", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Cliente.cidade;
                cmd.Parameters.Add("@estado", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Cliente.estado;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    efetuou = true;
                }
                conexao.Close();


            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return efetuou;
        }
        public static bool setAlteraCliente(Cliente Cliente)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE Cliente SET NOME_COMPLETO = @nomeCompleto, cpf = @cpf, data_nascimento = @dataNascimento, sexo = @sexo, cidade = @cidade, estado = @estado where id = @id", conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Cliente.id;
                cmd.Parameters.Add("@nomeCompleto", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Cliente.nome_completo;
                cmd.Parameters.Add("@cpf", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Cliente.cpf;
                cmd.Parameters.Add("@dataNascimento", NpgsqlTypes.NpgsqlDbType.Date).Value = Cliente.data_nascimento;
                cmd.Parameters.Add("@sexo", NpgsqlTypes.NpgsqlDbType.Char).Value = Cliente.sexo;
                cmd.Parameters.Add("@cidade", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Cliente.cidade;
                cmd.Parameters.Add("@estado", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Cliente.estado;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    efetuou = true;
                }
                conexao.Close();

            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("ERRO de SQL: " + erro.Message);
            }
            return efetuou;
        }

        public static bool setExcluiCliente(int id)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("delete from Cliente where id = @id", conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    efetuou = true;
                }
                conexao.Close();

            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("ERRO de SQL: " + erro.Message);
            }
            return efetuou;
        }
    }
}
