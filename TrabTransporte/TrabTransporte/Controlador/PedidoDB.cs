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
    class PedidoDB
    {
        public static List<Pedido> getPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM PEDIDO", conexao);
                NpgsqlDataReader data = select.ExecuteReader();

                while (data.Read())
                {
                    Cliente cliente = getCliente((int) data["cliente_id"]);
                    Transportadora transportadora = getTransportadora((int) data["transportadora_id"]);
                    List<PedidoItem> pedidoItens = getItensPedido((int) data["id"]);

                    pedidos.Add(
                        new Pedido(
                            (int)data["id"],
                            cliente,
                            transportadora,
                            DateTime.Parse(data["data_emissao"].ToString()),
                            DateTime.MinValue, //data["data_entrega"].ToString() != null ? DateTime.Parse(data["data_entrega"].ToString()) : 
                            double.Parse(data["valor_total"].ToString()),
                            pedidoItens)
                    );
                }
                data.Close();
                conexao.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return pedidos;
        }

        public static bool setExcluiPedido(int pedidoId)
        {
            bool deletouItensPedido = false;
            bool deletouPedido = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                { // Deleta todos os registros de itens do pedido
                    NpgsqlCommand cmdItensPedido = new NpgsqlCommand("DELETE FROM PEDIDO_ITEM WHERE PEDIDO_ID = @id", conexao);
                    cmdItensPedido.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = pedidoId;
                    if (cmdItensPedido.ExecuteNonQuery() == 1)
                    {
                        deletouItensPedido = true;
                    }
                }

                { // Deleta o registro de pepido
                    NpgsqlCommand cmdPedido = new NpgsqlCommand("DELETE FROM PEDIDO WHERE ID = @id", conexao);
                    cmdPedido.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = pedidoId;
                    if (cmdPedido.ExecuteNonQuery() == 1)
                    {
                        deletouPedido = true;
                    }
                }

                conexao.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }

            return deletouItensPedido && deletouPedido;
        }

        public static bool setIncluiPedido(Pedido pedido)
        {
            bool inseriuPedido = false;
            bool inseriuItensPedido = false;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO PEDIDO (CLIENTE_ID, TRANSPORTADORA_ID, DATA_EMISSAO, DATA_ENTREGA, VALOR_TOTAL) VALUES (@clienteId, @transportadoraId, CURRENT_TIMESTAMP, null, @valorTotal) RETURNING ID", conexao);
                cmd.Parameters.Add("@clienteId", NpgsqlTypes.NpgsqlDbType.Integer).Value = pedido.cliente.id;
                cmd.Parameters.Add("@transportadoraId", NpgsqlTypes.NpgsqlDbType.Integer).Value = pedido.transportadora.id;
                cmd.Parameters.Add("@valorTotal", NpgsqlTypes.NpgsqlDbType.Numeric).Value = pedido.valor_total;

                int idPedido = int.Parse(cmd.ExecuteScalar().ToString());
                

                if (idPedido > 0)
                {
                    inseriuPedido = true;
                }

                if (idPedido > 0 && pedido.PedidoItems.Count > 0)
                {
                    // Realiza uma inserção para cada registro de Item de Pedido
                    foreach (PedidoItem pedidoItem in pedido.PedidoItems)
                    {
                        NpgsqlCommand cmdItem = new NpgsqlCommand("INSERT INTO PEDIDO_ITEM (PEDIDO_ID, PRODUTO_ID, QUANTIDADE, VALOR_UNITARIO) VALUES (@pedidoId, @produtoId, @quantidade, @valorUnitario)", conexao);
                        cmdItem.Parameters.Add("@pedidoId", NpgsqlTypes.NpgsqlDbType.Integer).Value = idPedido;
                        cmdItem.Parameters.Add("@produtoId", NpgsqlTypes.NpgsqlDbType.Integer).Value = pedidoItem.produto.id;
                        cmdItem.Parameters.Add("@quantidade", NpgsqlTypes.NpgsqlDbType.Integer).Value = pedidoItem.quantidade;
                        cmdItem.Parameters.Add("@valorUnitario", NpgsqlTypes.NpgsqlDbType.Numeric).Value = pedidoItem.valor_unitario;

                        cmdItem.ExecuteNonQuery();
                    }
                    inseriuItensPedido = true;
                }
                
                conexao.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }
            return inseriuPedido && inseriuItensPedido;
        }

        private static Cliente getCliente(int idCliente)
        {
            Cliente cliente = null;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM CLIENTE WHERE ID = @id", conexao);
                select.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = idCliente;

                NpgsqlDataReader data = select.ExecuteReader();

                if (data.Read())
                {
                    cliente = new Cliente((int)data["id"], data["nome_completo"].ToString(), data["cpf"].ToString(), DateTime.Parse(data["data_nascimento"].ToString()), char.Parse(data["sexo"].ToString()), data["cidade"].ToString(), data["estado"].ToString());
                }
                data.Close();
                conexao.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }

            return cliente;
        }

        private static Transportadora getTransportadora(int idTransportadora)
        {
            Transportadora transportadora = null;

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM Transportadora WHERE ID = @id", conexao);
                select.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = idTransportadora;

                NpgsqlDataReader data = select.ExecuteReader();

                if (data.Read())
                {
                    transportadora = new Transportadora((int)data["id"], data["cnpj"].ToString(), data["descricao"].ToString(), data["cidade"].ToString(), data["estado"].ToString());
                }
                data.Close();
                conexao.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }

            return transportadora;
        }

        private static List<PedidoItem> getItensPedido(int idPedido)
        {
            List<PedidoItem> pedidoItens = new List<PedidoItem>();

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();

                NpgsqlCommand select = new NpgsqlCommand("SELECT " +
                    " pi.PEDIDO_ID, " +
                    " pi.PRODUTO_ID, " +
                    " pi.QUANTIDADE, " +
                    " pi.VALOR_UNITARIO, " +
                    " p.CODIGO, " +
                    " p.DESCRICAO, " +
                    " p.PESO " +
                    "FROM PEDIDO_ITEM pi " +
                    "JOIN PRODUTO p " +
                    "   ON p.ID = pi.PRODUTO_ID " +
                    "WHERE pi.PEDIDO_ID = @id", conexao);
                select.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = idPedido;

                NpgsqlDataReader data = select.ExecuteReader();

                while (data.Read())
                {
                    pedidoItens.Add(
                        new PedidoItem(
                            new Produto(
                                (int) data["produto_id"],
                                data["codigo"].ToString(),
                                data["descricao"].ToString(),
                                double.Parse(data["peso"].ToString())
                            ), 
                            (int) data["quantidade"],
                            double.Parse(data["valor_unitario"].ToString())
                        )
                    );
                }
                data.Close();
                conexao.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro de SQL: " + e.Message);
            }

            return pedidoItens;
        }
    }
}
