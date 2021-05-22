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
    public partial class FrmTransportadora : Form
    {
        private object dataGridViewProdutos;

        public FrmTransportadora()
        {
            InitializeComponent();
            atualizaTela();
        }

        private void atualizaTela()
        {
            dataGridViewTransportadoras.DataSource = TransportadoraDB.getTransportadoras();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new FrmTransportadoraNovo().ShowDialog();
            atualizaTela();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Transportadora transportadora = (Transportadora)dataGridViewTransportadoras.CurrentRow.DataBoundItem;
            new FrmTransportadoraAlterar(transportadora).ShowDialog();
            atualizaTela();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Transportadora transportadora = (Transportadora)dataGridViewTransportadoras.CurrentRow.DataBoundItem;
            DialogResult dialogResult = MessageBox.Show(null, "Deseja exluir a transportadora? ", "Transportadora", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (TransportadoraDB.setExcluiTransportadora(transportadora.id))
                {
                    MessageBox.Show("Transportadora Removida com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao remover a transportadora");
                }
            }
            atualizaTela();
        }
    }
}
