using System;
using System.Windows.Forms;
using TrabTransporte.Controlador;

namespace TrabTransporte.Views
{
    public partial class FrmProdutoNovo : Form
    {
        public FrmProdutoNovo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.Produto produto = new Modelo.Produto(-1, textBoxCodigo.Text, textBoxDescricao.Text, double.Parse(textBoxPeso.Text));
            if (ProdutoDB.setIncluiProduto(produto))
            {
                MessageBox.Show("Produto Incluído com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao inserir Produto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Utilizada para que o campo de peso só possa recer números e um ponto decimal
        private void textBoxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Para aceitar apenas 1 decipal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
