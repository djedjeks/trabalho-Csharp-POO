
using TrabTransporte.Controlador;
using System;
using System.Windows.Forms;
using TrabTransporte.Modelo;

namespace TrabTransporte.Views
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
            atualizaTela();
        }
        private void atualizaTela()
        {
            dataGridViewProdutos.DataSource = ProdutoDB.getProdutos();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            new FrmProdutoNovo().ShowDialog();
            atualizaTela();
        }

        private void btnAlteraProduto_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto) dataGridViewProdutos.CurrentRow.DataBoundItem;
            new FrmProdutoAlterar(produto).ShowDialog();
            atualizaTela();
        }

        private void btnDeletaProduto_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto) dataGridViewProdutos.CurrentRow.DataBoundItem;
            DialogResult dialogResult = MessageBox.Show(null, "Deseja exluir o Produto? ", "Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (ProdutoDB.setExcluiProduto(produto.id))
                {
                    MessageBox.Show("Produto Removido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao remover Produto");
                }
            }
            atualizaTela();
        }
    }
}
