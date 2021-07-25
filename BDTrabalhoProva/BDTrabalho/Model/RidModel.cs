using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BDTrabalho.Model
{
    class RidModel
    {
        public int Id { get; set; }

        public string Piloto { get; set; }
        public string Carro { get; set; }
        public string Observacao { get; set; }

        public DateTime Dia { get; set; }
        public TimeSpan Saida { get; set; }
        public TimeSpan Chegada { get; set; }

        public decimal MultaPreco { get; set; }
        public int MultaPontos { get; set; }
        public bool TeveMulta { get; set; }

    }
}
