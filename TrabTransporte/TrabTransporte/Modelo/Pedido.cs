using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabTransporte.Modelo
{
    public class Pedido
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Transportadora transportadora { get; set; }
        public DateTime data_emissao { get; set; }
        public DateTime data_entrega { get; set; }
        public double valor_total { get; set; }
        public List<PedidoItem> PedidoItems { get; set; }

        public Pedido(int id, Cliente cliente, Transportadora transportadora, DateTime data_emissao, DateTime data_entrega, double valor_total, List<PedidoItem> pedidoItems)
        {
            this.id = id;
            this.cliente = cliente;
            this.transportadora = transportadora;
            this.data_emissao = data_emissao;
            this.data_entrega = data_entrega;
            this.valor_total = valor_total;
            PedidoItems = pedidoItems;
        }

        public String cliente_nome()
        {
            return this.cliente.nome_completo;
        }
    }
}
