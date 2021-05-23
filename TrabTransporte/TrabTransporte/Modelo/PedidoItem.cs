using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabTransporte.Modelo
{
    public class PedidoItem
    {
        public Produto produto { get; set; }
        public int quantidade { get; set; }

        public double valor_unitario { get; set; }

        public PedidoItem(Produto produto, int quantidade, double valor_unitario)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.valor_unitario = valor_unitario;
        }
    }
}
