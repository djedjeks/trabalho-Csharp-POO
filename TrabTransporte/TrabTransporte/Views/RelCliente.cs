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

namespace TrabTransporte.Views
{
    public partial class RelCliente : Form
    {
        public RelCliente()
        {
            InitializeComponent();
        }

        private void RelCliente_Load(object sender, EventArgs e)
        {
            ClienteBindingSource.DataSource = ClienteDB.getClientes();
            this.reportViewer1.RefreshReport();
        }
    }
}
