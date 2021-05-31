using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabTransporte.Controlador;
using TrabTransporte.Modelo;

namespace TrabTransporte.Views
{
    public partial class FrmPedido : Form
    {
        private List<Pedido> pedidos = null;
        public FrmPedido()
        {
            InitializeComponent();
            atualizaTela();
        }

        private void atualizaTela()
        {
            this.pedidos = PedidoDB.getPedidos();
            dataGridViewPedidos.Rows.Clear();
            foreach (Pedido pedido in this.pedidos)
            {
                dataGridViewPedidos.Rows.Add(
                    pedido.id,
                    pedido.cliente.nome_completo,
                    pedido.transportadora.descricao,
                    pedido.data_emissao,
                    pedido.data_entrega == DateTime.MinValue ? "" : pedido.data_entrega,
                    pedido.valor_total
                    );
            }
        }

        private void btnDetalharPedido_Click(object sender, EventArgs e)
        {
            int pedidoIdSelecionado = int.Parse(dataGridViewPedidos.CurrentRow.Cells[0].Value.ToString());
            Pedido pedidoSelecionado = null;
            foreach(Pedido pedido in this.pedidos)
            {
                if(pedido.id == pedidoIdSelecionado)
                {
                    pedidoSelecionado = pedido;
                    break;
                }
            }

            new FrmPedidoDetalhes(pedidoSelecionado).ShowDialog();
            atualizaTela();
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            int pedidoIdSelecionado = int.Parse(dataGridViewPedidos.CurrentRow.Cells[0].Value.ToString());
            Pedido pedidoS = null;
            
            foreach(Pedido p in this.pedidos)
            {
                if(p.id == pedidoIdSelecionado)
                {
                    pedidoS = p;
                    break;
                }
            }

            if (pedidoS != null)
            {
                new FrmPedidoAlterar(pedidoS).ShowDialog();
            } else
            {
                MessageBox.Show("Pedido não encontrado. Selecione um pedido antes de editá-lo.");
            }
            atualizaTela();
        }

        private void btnDeletarPedido_Click(object sender, EventArgs e)
        {
            int pedidoIdSelecionado = int.Parse(dataGridViewPedidos.CurrentRow.Cells[0].Value.ToString());

            DialogResult dialogResult = MessageBox.Show(null, "Tem certeza que deleja exclur este pedido?", "Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (PedidoDB.setExcluiPedido(pedidoIdSelecionado))
                {
                    MessageBox.Show("Pedido Removido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao remover Pedido");
                }
            }
            atualizaTela();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            new FrmPedidoNovo().ShowDialog();
            atualizaTela();
        }
    }
}
