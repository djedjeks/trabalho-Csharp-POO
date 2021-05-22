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
    public partial class FrmClienteNovo : Form
    {
        public FrmClienteNovo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(-1, textBoxNomeCompleto.Text, textBoxCpf.Text, dateTimePickerDataNascimento.Value, char.Parse(textBoxSexo.Text), textBoxCidade.Text, textBoxEstado.Text);
            if (ClienteDB.setIncluiCliente(cliente))
            {
                MessageBox.Show("Cliente Incluído com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao inserir Cliente");
            }
        }
    }
}
