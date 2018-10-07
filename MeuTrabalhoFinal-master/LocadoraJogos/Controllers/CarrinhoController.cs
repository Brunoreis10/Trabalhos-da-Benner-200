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

            foreach (var item in carrinho.ItensPedido)
            {
                if (item.Produto.Id == produto.Id)
                {
                    item.Quantidade++;
                    Session["Carrinho"] = carrinho;
                    return RedirectToAction("Carrinho");
                }
            }
            carrinho.AdicionaProduto(produto);
            Session["Carrinho"] = carrinho;
            return RedirectToAction("Carrinho");
        }
        public ActionResult TirarCarrinho(int id)
        {
            var carrinho = Session["Carrinho"] != null ? (Pedido)Session["Carrinho"] : new Pedido();


            var produto = new ProdutosDAO().BuscaPorId(id);

            foreach (var item in carrinho.ItensPedido)
            {
                if (item.Produto.Id == produto.Id)
                {
                    item.Quantidade--;
                    Session["Carrinho"] = carrinho;
                    if (item.Quantidade == 0)
                        return ExcluiProdutoCarrinho(id);
                    else
                        return RedirectToAction("Carrinho");
                }
            }
            carrinho.AdicionaProduto(produto);
            Session["Carrinho"] = carrinho;
            return RedirectToAction("Carrinho");
        }
        public ActionResult ExcluiProdutoCarrinho(int id)
        {
            var carrinho = Session["Carrinho"] != null ? (Pedido)Session["Carrinho"] : new Pedido();
            var produto = new ProdutosDAO().BuscaPorId(id);
            carrinho.RemoverProduto(produto.Id);
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

        //[Route("AplicaDesconto")]
        public ActionResult AdicionarDesconto(string codigo)
        {
            DescontoDAO dao = new DescontoDAO();
            Desconto desconto = dao.BuscaPorCodigo(codigo);
            if (desconto == null)
            {
                return Json(new { sucesso = false, resposta  ="Digite um código válido" },JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { sucesso = true, desconto =  desconto.PorcentagemDeDesconto }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}