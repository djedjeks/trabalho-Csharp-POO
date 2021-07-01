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

namespace ConFin.Views
{
    public partial class RelProduto : Form
    {

        public RelProduto()
        {
            InitializeComponent();
        }

        private void RelProduto_Load(object sender, EventArgs e)
        {
            ProdutoBindingSource.DataSource = ProdutoDB.getProdutos();
            this.reportViewer1.RefreshReport();
        }
    }
}
