using LocadoraJogos.DAO;
using LocadoraJogos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraJogos.Controllers
{

    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastra(Usuario usuario)
        {
            var dao = new UsuarioDAO();

            if (usuario.ValidaCadastro())
            {
                TempData["Login"] = usuario.Nome;
                TempData["Senha"] = usuario.Senha;
                dao.Adiciona(usuario);
                return RedirectToAction("Index", "Home");
            }

            return Json(new { incorreto = true });


            //return Json(new { incorreto = true });
        }


    }
}