using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaWebVuelos.Data;
using SistemaWebVuelos.Models;

namespace SistemaWebVuelos.Controllers
{
    public class VueloController : Controller
    {

        DbVueloContext context = new DbVueloContext();
        // GET: Vuelo
        public ActionResult Index()
        {
            var vuelos = context.Vuelos.ToList();
            return View("Index", vuelos);
        }
        public ActionResult Listar(string destino)
        {

            var vuelos = (from o in context.Vuelos
                          where o.Destino == destino
                          select o).ToList();

            return View("Index", vuelos);
        }

        public ActionResult Create()
        {
            Vuelo vuelo = new Vuelo();
            return View("Create", vuelo);
        }

        [HttpPost]
        public ActionResult Create(Vuelo vuelo)
        {
            context.Vuelos.Add(vuelo);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Detail(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);
            if (vuelo != null)
            {
                return View("Detail", vuelo);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Delete(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);

            if (vuelo != null)
            {
                return View("Delete", vuelo);
            }
            else
            {
                return HttpNotFound();
            }

        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);

            context.Vuelos.Remove(vuelo);
            context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}