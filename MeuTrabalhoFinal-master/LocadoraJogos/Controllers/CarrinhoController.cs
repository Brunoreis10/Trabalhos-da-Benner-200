using LocadoraJogos.DAO;
using LocadoraJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraJogos.Controllers
{
    public class CarrinhoController : Controller
    {
        // GET: Carrinho
        public ActionResult AdicionarCarrinho(int id)
        {
            var carrinho = Session["Carrinho"] != null ? (Pedido)Session["Carrinho"] : new Pedido();

            var produto = new ProdutosDAO().BuscaPorId(id);

            carrinho.AdicionaProduto(produto);

            Session["Carrinho"] = carrinho;

            return RedirectToAction("Carrinho");
        }

        public ActionResult Carrinho()
        {
            Pedido carrinho = Session["Carrinho"] != null ? (Pedido)Session["Carrinho"] : new Pedido();
            var produtos = carrinho.ItensPedido;
            ViewBag.Produtos = produtos;
            return View(carrinho);
        }
    }
}