using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Models
{
    public class Desconto
    {
        public int Id { get; set; }
        public int PorcentagemDeDesconto{ get; set; }

        public string CodigoDoDesconto { get; set; }
    }
}