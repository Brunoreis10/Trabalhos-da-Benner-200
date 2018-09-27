using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Models
{
    public class Administrador : Usuario
    {
        public string ChaveDeSeguranca { get; set; }
    }
}