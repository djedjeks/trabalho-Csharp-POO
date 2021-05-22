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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            atualizaTela();
        }
        private void atualizaTela()
        {
            dataGridViewClientes.DataSource = ClienteDB.getClientes();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            new FrmClienteNovo().ShowDialog();
            atualizaTela();
        }

        private void btnAlteraCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente) dataGridViewClientes.CurrentRow.DataBoundItem;
            new FrmClienteAlterar(cliente).ShowDialog();
            atualizaTela();
        }

        private void btnDeletaCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente) dataGridViewClientes.CurrentRow.DataBoundItem;
            DialogResult dialogResult = MessageBox.Show(null, "Deseja exluir o Cliente? ", "Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (ClienteDB.setExcluiCliente(cliente.id))
                {
                    MessageBox.Show("Cliente Removido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao remover Cliente");
                }
            }
            atualizaTela();
        }
    }
}
