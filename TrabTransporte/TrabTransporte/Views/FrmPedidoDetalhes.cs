using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabTransporte.Modelo;

namespace TrabTransporte.Views
{
    public partial class FrmPedidoDetalhes : Form
    {
        private Pedido pedido = null;
        public FrmPedidoDetalhes(Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;

            textBoxPedidoId.Text = this.pedido.id.ToString();
            textBoxDataEmissao.Text = this.pedido.data_emissao.ToString();
            textBoxDataEntrega.Text = this.pedido.data_entrega.ToString();
            textBoxValorTotal.Text = this.pedido.valor_total.ToString();

            textBoxClienteNome.Text = this.pedido.cliente.nome_completo;
            textBoxClienteCPF.Text = this.pedido.cliente.cpf;
            textBoxClienteSexo.Text = this.pedido.cliente.sexo.ToString();
            textBoxClienteCidade.Text = this.pedido.cliente.cidade;
            textBoxClienteEstado.Text = this.pedido.cliente.estado;

            textBoxTransportadoraNome.Text = this.pedido.transportadora.descricao;
            textBoxTransportadoraCNPJ.Text = this.pedido.transportadora.cnpj;
            textBoxTransportadoraCidade.Text = this.pedido.transportadora.cidade;
            textBoxTransportadoraEstado.Text = this.pedido.transportadora.estado;

            foreach(PedidoItem pedidoItem in this.pedido.PedidoItems)
            {
                dataGridViewProdutos.Rows.Add(
                    pedidoItem.produto.codigo,
                    pedidoItem.produto.descricao,
                    pedidoItem.quantidade,
                    pedidoItem.valor_unitario,
                    pedidoItem.produto.peso
                );
            }
            
        }
    }
}
