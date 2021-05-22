using TrabTransporte.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabTransporte.Controlador
{
    class ProdutoDB
    {
        public static List<Produto> getProdutos()
        {
            List<Produto> Produtos = new List<Produto>();

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM Produto", conexao);
                NpgsqlDataReader data = select.ExecuteReader();

                while (data.Read())
                {
                    Produtos.Add(
                        new Produto((int)data["id"], data["codigo"].ToString(), data["descricao"].ToString(), data.GetDouble(3)));
                }
                data.Close();
                conexao.Close();


            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return Produtos;
        }

        public static bool setIncluiProduto(Produto Produto)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO PRODUTO (CODIGO, DESCRICAO, PESO) VALUES (@codigo, @descricao, @peso)", conexao);
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Produto.codigo;
                cmd.Parameters.Add("@descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Produto.descricao;
                cmd.Parameters.Add("@peso", NpgsqlTypes.NpgsqlDbType.Numeric).Value = Produto.peso;
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
        public static bool setAlteraProduto(Produto Produto)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE PRODUTO SET codigo = @codigo, descricao = @descricao, peso = @peso where id = @id", conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Produto.id;
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Produto.codigo;
                cmd.Parameters.Add("@descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Produto.descricao;
                cmd.Parameters.Add("@peso", NpgsqlTypes.NpgsqlDbType.Numeric).Value = Produto.peso;

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

        public static bool setExcluiProduto(int id)
        {
            bool efetuou = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("delete from Produto where id = @id", conexao);
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
