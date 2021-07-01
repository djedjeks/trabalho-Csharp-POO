using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabTransporte.Modelo
{
    public class Transportadora
    {

        public int id { get; set; }
        public string cnpj { get; set; }
        public string descricao { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        public Transportadora(int id, string cnpj, string descricao, string cidade, string estado)
        {
            this.id = id;
            this.cnpj = cnpj;
            this.descricao = descricao;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}
