using LocadoraJogos.DAO;
using LocadoraJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LocadoraJogos.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String usuario, String senha)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario user = dao.Busca(usuario, senha);
            if (user != null)
            {
                Session["usuarioLogado"] = user.Id;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [Route ("LogOut", Name ="SairConta")]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); 
            return RedirectToAction("Index");
        }

    }
}