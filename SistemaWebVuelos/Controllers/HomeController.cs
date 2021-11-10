﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebVuelos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToLongTimeString();
            ViewBag.Saludo = "Bienvenidos al sitio web";
            return View();

        }

    }
}