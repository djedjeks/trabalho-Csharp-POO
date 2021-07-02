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
    public partial class RelTransportadora : Form
    {
        public RelTransportadora()
        {
            InitializeComponent();
        }

        private void RelTransportadora_Load(object sender, EventArgs e)
        {
            TransportadoraBindingSource.DataSource = TransportadoraDB.getTransportadoras();
            this.reportViewer1.RefreshReport();
        }
    }
}
