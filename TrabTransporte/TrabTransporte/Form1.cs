using ConFin.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabTransporte.Views;

namespace TrabTransporte
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void produtos_Click(object sender, EventArgs e)
        {
            new FrmProduto().ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new FrmCliente().ShowDialog();
        }

        private void btnTransportadoras_Click(object sender, EventArgs e)
        {
            new FrmTransportadora().ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            new FrmPedido().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RelProduto().ShowDialog();
        }
    }
}
