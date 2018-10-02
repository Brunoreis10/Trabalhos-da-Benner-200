using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DtPedido { get; set; }
        public StatusPedido StatusPedido { get; set; } // StatusPedido seria um Enum

        public DateTime DtPagamento { get; set; }
        public Decimal ValorTotal { get; set; }

        public Usuario Usuario { get; set; }
        public IList<ItemPedido> ItensPedido { get; set; }

        public Pedido()
        { 
            ItensPedido = new List<ItemPedido>();
        }

        public void AdicionaProduto(Produto produto)
        {
            ItensPedido.Add(new ItemPedido() { Produto = produto, Quantidade = 1 });
        }

        public void RemoverProduto(int id)
        {
            foreach(var item in ItensPedido)
            {
                if (item.Produto.Id == id)
                {
                    ItensPedido.Remove(item);
                    break;
                }
            }
        }

        public void MudaQuantidade(int produtoId, int quantidade)
        {
            foreach (var item in ItensPedido)
            {
                if (item.Produto.Id == produtoId)
                {
                    item.Quantidade = quantidade;
                    break;
                }
            }
        }

    }
}