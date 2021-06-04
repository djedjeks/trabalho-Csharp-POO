using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabTransporte.Modelo
{
    public class PedidoItem
    {
        public int id { get; set; }
        public Produto produto { get; set; }
        public int quantidade { get; set; }
        public double valor_unitario { get; set; }

        public PedidoItem(int id, Produto produto, int quantidade, double valor_unitario)
        {
            this.id = id;
            this.produto = produto;
            this.quantidade = quantidade;
            this.valor_unitario = valor_unitario;
        }
    }
}
