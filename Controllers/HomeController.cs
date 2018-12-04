using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var filmes = new Filmes
            {
                FilmeId = 1,
                FilmeNome = "O Grande Dragão Branco",
                FilmeGenero = "Porradaria, Socão & Voadora Lendária"
            };

            return View(filmes);
        }
        public ActionResult Contatos()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(FormCollection form)
        {
            ViewData["FilmeId"] = form["FilmeId"];
            ViewData["FilmeNome"] = form["FilmeNome"];
            ViewData["FilmeGenero"] =form["FilmeGenero"];

            return View();
        }
    }
}