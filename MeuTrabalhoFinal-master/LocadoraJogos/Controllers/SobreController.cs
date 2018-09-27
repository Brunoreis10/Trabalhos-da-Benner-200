using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraJogos.Controllers
{
    public class SobreController : Controller
    {
        // GET: Sobre
        public ActionResult Index()
        {/*
            var base64 = Convert.ToBase64String(ArrayArquivo);
            var extensao = "png";
            string oQueGuardar = $"data:image/{extensao};base64,{base64}";*/
            return View();
        }
    }
}