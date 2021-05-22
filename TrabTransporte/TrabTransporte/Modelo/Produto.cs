using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabTransporte.Modelo
{
    public class Produto
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public double peso { get; set; }

        public Produto(int id, string codigo, string descricao, double peso)
        {
            this.id = id;
            this.codigo = codigo;
            this.descricao = descricao;
            this.peso = peso;
        }
    }
}
