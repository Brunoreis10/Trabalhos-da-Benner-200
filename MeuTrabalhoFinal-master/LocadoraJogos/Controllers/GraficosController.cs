using LocadoraJogos.DAO;
using LocadoraJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraJogos.Controllers
{
    public class GraficosController : Controller
    {
        // GET: Graficos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PegaDadosGrafico()
        {
            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista().OrderByDescending(p => p.Quantidade).ToList();
            var lista = produtos.Select(produto => new { Nome = produto.Nome,Quantidade = produto.Quantidade });
            return Json(new { Produtos = lista }, JsonRequestBehavior.AllowGet);
        }
    }
}