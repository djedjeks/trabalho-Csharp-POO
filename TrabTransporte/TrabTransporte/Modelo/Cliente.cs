using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabTransporte.Modelo
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome_completo { get; set; }
        public string cpf { get; set; }
        public DateTime data_nascimento { get; set; }
        public char sexo { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        public Cliente(int id, string nome_completo, string cpf, DateTime data_nascimento, char sexo, string cidade, string estado)
        {
            this.id = id;
            this.nome_completo = nome_completo;
            this.cpf = cpf;
            this.data_nascimento = data_nascimento;
            this.sexo = sexo;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}
