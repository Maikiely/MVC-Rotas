using MVC_Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Rotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia>todasAsNoticias;

        public HomeController()
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.data);
        }
        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);
            var todasCategorias = todasAsNoticias.Select(x => x.categoria).Distinct().ToList();

            ViewBag.Categoria = todasCategorias;
            return View(ultimasNoticias);
        }
        
        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostraNoticia(int noticiaID, string categoria, string titulo)
        {
            return View(todasAsNoticias.FirstOrDefault(x => x.noticiaID == noticiaID));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.categoria = categoria;
            return View(categoriaEspecifica);
        }
    }
}