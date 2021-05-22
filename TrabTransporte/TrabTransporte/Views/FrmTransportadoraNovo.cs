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
    public partial class FrmTransportadoraNovo : Form
    {
        public FrmTransportadoraNovo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Transportadora transportadora = new Transportadora(-1, textBoxCNPJ.Text, textBoxDescricao.Text, textBoxCidade.Text, textBoxEstado.Text);
            if (TransportadoraDB.setIncluiTransportadora(transportadora))
            {
                MessageBox.Show("Transportadora Incluído com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao inserir Transportadora");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
