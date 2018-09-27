using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Models
{
    public class ItemPedido
    {
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }
}