using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocadoraJogos.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [StringLength(20)]
        public String Nome { get; set; }

        public decimal Preco { get; set; }

        public CategoriaDoProduto Categoria { get; set; }

        public int? CategoriaId { get; set; }

        public String Descricao { get; set; }

        public int Quantidade { get; set; }
        public IList<ItemPedido> PedidosProduto { get; set; }

        public byte[] Imagem { get; set; }
    }
}