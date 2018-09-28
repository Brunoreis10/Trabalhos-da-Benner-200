using LocadoraJogos.DAO;
using LocadoraJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LocadoraJogos.Views
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        //public ActionResult Index()
        //{
        //    Usuario usuario = (Usuario)Session["Administrador"];
        //    ProdutosDAO dao = new ProdutosDAO();
        //    IList<Produto> produtos = dao.Lista();
        //    ViewBag.Produtos = produtos;
        //    if (usuario.Adminstrador == true)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }


        //}

        public ActionResult Index()
        {
            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }

        public ActionResult ExcluiQtd(int id)
        {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(id);
            produto.Quantidade--;
            dao.Atualiza(produto);
            return Json(produto);
        }

        public ActionResult AumentaQtd(int id)
        {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(id);
            produto.Quantidade++;
            dao.Atualiza(produto);
            return Json(produto);
        }
        public ActionResult Form()
        {
            return View();
        }


        public ActionResult Adiciona(Produto produto, HttpPostedFileBase upload)
        {
            if(upload != null && upload.ContentLength > 0)
            {

                using (System.IO.Stream inputStream = upload.InputStream)
                {
                    System.IO.MemoryStream memoryStream = inputStream as System.IO.MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new System.IO.MemoryStream();
                        inputStream.CopyTo(memoryStream);
                    }
                    produto.Imagem = memoryStream.ToArray();
                }
            }
            ProdutosDAO dao = new ProdutosDAO();
            dao.Adiciona(produto);

            return View();
        }
    }

    
}