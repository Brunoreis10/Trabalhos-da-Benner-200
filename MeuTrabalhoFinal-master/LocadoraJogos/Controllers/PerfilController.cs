using LocadoraJogos.DAO;
using LocadoraJogos.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraJogos.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Index()
        {
            var userId = (Int32)HttpContext.Session["usuarioLogado"]; //pega id do usuario da session
            UsuarioDAO dao = new UsuarioDAO();

            var logado = dao.BuscaPorId(userId); //logado = usuario da session

            ViewBag.Usuario = logado; //Passando na viewbag o usuario da sessao atual!


            return View();
        }

    }
}