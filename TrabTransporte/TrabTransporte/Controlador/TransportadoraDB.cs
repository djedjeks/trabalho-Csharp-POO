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
    class TransportadoraDB
    {
        public static List<Transportadora> getTransportadoras()
        {
            List<Transportadora> Transportadoras = new List<Transportadora>();

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM Transportadora", conexao);
                NpgsqlDataReader data = select.ExecuteReader();

                while (data.Read())
                {
                    Transportadoras.Add(new Transportadora((int)data["id"], data["cnpj"].ToString(), data["descricao"].ToString(), data["cidade"].ToString(), data["estado"].ToString()));
                       
                }
                data.Close();
                conexao.Close();


            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return Transportadoras;
        }

        public static bool setIncluiTransportadora(Transportadora Transportadora)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO Transportadora (CNPJ, DESCRICAO, CIDADE, ESTADO) VALUES (@CNPJ, @DESCRICAO, @CIDADE, @ESTADO)", conexao);
                cmd.Parameters.Add("@CNPJ", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transportadora.cnpj;
                cmd.Parameters.Add("@DESCRICAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transportadora.descricao;
                cmd.Parameters.Add("@CIDADE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transportadora.cidade;
                cmd.Parameters.Add("@ESTADO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transportadora.estado;
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
        public static bool setAlteraTransportadora(Transportadora Transportadora)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE Transportadora SET CNPJ =  @CNPJ, DESCRICAO = @DESCRICAO, CIDADE = @CIDADE, ESTADO = @ESTADO where id = @id", conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Transportadora.id;
                cmd.Parameters.Add("@CNPJ", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transportadora.cnpj;
                cmd.Parameters.Add("@DESCRICAO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transportadora.descricao;
                cmd.Parameters.Add("@CIDADE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transportadora.cidade;
                cmd.Parameters.Add("@ESTADO", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transportadora.estado;
                

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

        public static bool setExcluiTransportadora(int id)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("delete from Transportadora where id = @id", conexao);
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
