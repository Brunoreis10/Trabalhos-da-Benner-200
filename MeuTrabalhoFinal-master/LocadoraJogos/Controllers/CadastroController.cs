using LocadoraJogos.DAO;
using LocadoraJogos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return Json(new { incorreto = true });
            }

        }
        [HttpPost]
        public ActionResult ValidaCadastro(string usuario)
        {
            var dao = new UsuarioDAO();
            var usuarioObj = dao.BuscaPorNomePessoa(usuario);
            if (usuarioObj != null && usuarioObj.ValidaCadastro())
            {
                return Json(new { incorreto = false });
            }
            else
            {
                return Json(new { incorreto = true });
            }

        }
        public JsonResult VerificaNomeBD(string nome)
        {
            var dao = new UsuarioDAO();
            return Json(new { existe = dao.BuscaPorNome(nome) });
        }


    }
}