using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void atualizaValorFinal()
        {
            float valorFinal = 0;

            foreach (DataGridViewRow dgvr in dataGridViewProdutos.Rows)
            {
                if ((dgvr.Cells["quantidade"].Value != null && !"".Equals(dgvr.Cells["quantidade"].Value))
                    && (dgvr.Cells["valorUnitario"].Value != null && !"".Equals(dgvr.Cells["valorUnitario"].Value)))
                {
                    int quantidade = int.Parse(dgvr.Cells["quantidade"].Value.ToString());
                    float valorUnitario = float.Parse(dgvr.Cells["valorUnitario"].Value.ToString().Replace(".", ","));

                    valorFinal += quantidade * valorUnitario;
                }
            }


            textBoxValorTotal.Text = valorFinal.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validaFormularioCadastro()
        {

            if (comboBoxCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Necessário selecionar um Cliente!");
                return false;
            }

            if (comboBoxTransportadora.SelectedIndex < 0)
            {
                MessageBox.Show("Necessário selecionar uma Transportadora!");
                return false;
            }

            if ((textBoxValorTotal == null) || ("".Equals(textBoxValorTotal.Text.Trim())) || (double.Parse(textBoxValorTotal.Text) <= 0))
            {
                MessageBox.Show("Necessário selecionar pelo menos 1 Produto!");
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            atualizaValorFinal();

            Cliente clienteS = null;
            Transportadora transportadoraS = null;
            List<PedidoItem> itensPedidoS = new List<PedidoItem>();

            if (!validaFormularioCadastro())
            {
                return;
            }

            String cliString = comboBoxCliente.Items[comboBoxCliente.SelectedIndex].ToString();
            int cliId = int.Parse(cliString.Substring(0, cliString.IndexOf(" - ")));
            foreach (Cliente cliente in this.clientes)
            {
                if (cliente.id == cliId)
                {
                    clienteS = cliente;
                    break;
                }
            }

            String transpString = comboBoxTransportadora.Items[comboBoxTransportadora.SelectedIndex].ToString();
            int transpId = int.Parse(transpString.Substring(0, transpString.IndexOf(" - ")));
            foreach (Transportadora transportadora in this.transportadoras)
            {
                if (transportadora.id == transpId)
                {
                    transportadoraS = transportadora;
                    break;
                }
            }

            if(clienteS != null && transportadoraS != null)
            {
                foreach(DataGridViewRow dgvr in dataGridViewProdutos.Rows)
                {
                    if(dgvr.Cells[0].Value != null && dgvr.Cells[1].Value != null && dgvr.Cells[2].Value != null)
                    {
                        Produto produtoSelecionado = null;
                        String prodString = dgvr.Cells[0].Value.ToString();
                        int prodId = int.Parse(prodString.Substring(0, prodString.IndexOf(" - ")));
                        foreach (Produto prod in this.produtos)
                        {
                            if (prod.id == prodId)
                            {
                                produtoSelecionado = prod;
                                break;
                            }
                        }

                        if(produtoSelecionado != null)
                        {
                            int quantidade = int.Parse(dgvr.Cells["quantidade"].Value.ToString());
                            double valorUnitario = double.Parse(dgvr.Cells["valorUnitario"].Value.ToString().Replace(".", ","));

                            itensPedidoS.Add(new PedidoItem(-1, produtoSelecionado, quantidade, valorUnitario));
                        } else
                        {
                            MessageBox.Show("Falha ao identificar Produto!");
                            return;
                        }
                    }
                }

                double valorTotal = double.Parse(textBoxValorTotal.Text.Replace(".", ","));
                Pedido pedido = new Pedido(-1, clienteS, transportadoraS, valorTotal, itensPedidoS);

                if (PedidoDB.setIncluiPedido(pedido))
                {
                    MessageBox.Show("Pedido Registrado com sucesso!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha ao registrar Pedido!");
                    return;
                }
            } else
            {
                MessageBox.Show("Falha ao identificar Cliente e/ou Transportadora!");
                return;
            }
        }



        // Adiciona eventos para permitir apenas valores numéricos sobre os campos de quantidade e valor do produto
        private void dataGridViewProdutos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(intColumn_KeyPress);
            e.Control.KeyPress -= new KeyPressEventHandler(doubleColumn_KeyPress);
            if (dataGridViewProdutos.CurrentCell.ColumnIndex == 1) //Coluna de Quantidade
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(intColumn_KeyPress);
                }
                atualizaValorFinal();

            } else if(dataGridViewProdutos.CurrentCell.ColumnIndex == 2) //Coluna de Valor Unitário
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(doubleColumn_KeyPress);
                }
                atualizaValorFinal();
            }
        }


        //Remove todo caracter não numérico digitado
        private void intColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Remove todo caracter não numérico digitado, permitindo apenas um ponto
        private void doubleColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Para aceitar apenas 1 decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //Ao alterar o valor de uma celula e a mesma for de quantidade ou de valor, atualiza o valor final
        private void dataGridViewProdutos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProdutos.CurrentCell != null && 
                (dataGridViewProdutos.CurrentCell.ColumnIndex == 1 || dataGridViewProdutos.CurrentCell.ColumnIndex == 2))
            {
                atualizaValorFinal();
            }
        }
    }
}
