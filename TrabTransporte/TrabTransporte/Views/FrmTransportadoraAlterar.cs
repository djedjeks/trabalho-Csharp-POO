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
    public partial class FrmTransportadoraAlterar : Form
    {
        Transportadora transportadora = null; 

        public FrmTransportadoraAlterar(Transportadora transportadora)
        {

            InitializeComponent();
            this.transportadora = transportadora;
            textBoxCNPJ.Text = this.transportadora.cnpj;
            textBoxDescricao.Text = this.transportadora.descricao;
            textBoxCidade.Text = this.transportadora.cidade;
            textBoxEstado.Text = this.transportadora.estado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPeso_TextChanged(object sender, EventArgs e)
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

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.transportadora.cnpj = textBoxCNPJ.Text;
            this.transportadora.descricao = textBoxDescricao.Text;
            this.transportadora.cidade = textBoxCidade.Text;
            this.transportadora.estado = textBoxEstado.Text;

            if (TransportadoraDB.setAlteraTransportadora(this.transportadora))
            {
                MessageBox.Show("Transportadora alterada com Sucesso!");
                Close();
            }else
            {
                MessageBox.Show("Falha ao Alterar a Transportadora");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
