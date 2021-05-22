using TrabTransporte.Modelo;
using TrabTransporte.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabTransporte.Views
{
    public partial class FrmProdutoAlterar : Form
    {
        Produto produto = null;

        public FrmProdutoAlterar(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            textBoxCodigo.Text = this.produto.codigo;
            textBoxDescricao.Text = this.produto.descricao;
            textBoxPeso.Text = this.produto.peso.ToString("F2");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            produto.codigo = textBoxCodigo.Text;
            produto.descricao = textBoxDescricao.Text;
            produto.peso = double.Parse(textBoxPeso.Text);

            if (ProdutoDB.setAlteraProduto(produto))
            {
                MessageBox.Show("Produto Alterado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao alterar Produto");
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
