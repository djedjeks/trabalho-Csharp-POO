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
    public partial class FrmPedidoNovo : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Transportadora> transportadoras= new List<Transportadora>();
        List<Produto> produtos = new List<Produto>();

        public FrmPedidoNovo()
        {
            InitializeComponent();
            this.clientes = ClienteDB.getClientes();
            this.transportadoras = TransportadoraDB.getTransportadoras();
            this.produtos = ProdutoDB.getProdutos();

            montaListaClientes();
            montaListaTransportadoras();
            montaListaProdutos();
        }

        private void montaListaClientes()
        {
            comboBoxCliente.Items.Clear();
            int cnt = comboBoxCliente.Items.Count;
            foreach (Cliente cliente in this.clientes)
            {
                comboBoxCliente.Items.Insert(cnt, (cliente.id + " - " + cliente.nome_completo));
                cnt++;
            }
        }

        private void montaListaTransportadoras()
        {
            comboBoxTransportadora.Items.Clear();
            int cnt = comboBoxTransportadora.Items.Count;
            foreach (Transportadora transportadora in this.transportadoras)
            {
                comboBoxTransportadora.Items.Insert(cnt, (transportadora.id + " - " + transportadora.descricao));
                cnt++;
            }
        }

        private void montaListaProdutos()
        {
            int cnt = produto.Items.Count;
            foreach (Produto prod in this.produtos)
            {
                produto.Items.Insert(cnt, (prod.id + " - " + prod.descricao));
                cnt++;
            }
        }

        private void dataGridViewProdutos_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["quantidade"].Value = "1";
            e.Row.Cells["valorUnitario"].Value = "0";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
