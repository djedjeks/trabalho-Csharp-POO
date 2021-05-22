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
    public partial class FrmClienteAlterar : Form
    {
        Cliente cliente = null;

        public FrmClienteAlterar(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;

            textBoxCpf.Text = this.cliente.cpf;
            textBoxNomeCompleto.Text = this.cliente.nome_completo;
            dateTimePickerDataNascimento.Value = this.cliente.data_nascimento;
            textBoxSexo.Text = this.cliente.sexo.ToString();
            textBoxCidade.Text = this.cliente.cidade;
            textBoxEstado.Text = this.cliente.estado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.cliente.cpf = textBoxCpf.Text;
            this.cliente.nome_completo = textBoxNomeCompleto.Text;
            this.cliente.data_nascimento = dateTimePickerDataNascimento.Value;
            this.cliente.sexo = char.Parse(textBoxSexo.Text);
            this.cliente.cidade = textBoxCidade.Text;
            this.cliente.estado = textBoxEstado.Text;

            if (ClienteDB.setAlteraCliente(this.cliente))
            {
                MessageBox.Show("Cliente Alterado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao alterar Cliente");
            }
        }
    }
}
