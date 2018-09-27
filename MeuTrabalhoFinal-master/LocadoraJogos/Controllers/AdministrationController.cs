using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocadoraJogos.Controllers
{
    public class AdministrationController : Controller
    {
        // GET: Administration
        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            

            return View();
        }

    }

}