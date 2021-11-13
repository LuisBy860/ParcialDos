using ParcialDos.Models;
using ParcialDos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcialDos.Controllers
{
    public class InscripcionController : Controller
    {
        EnrollementsRepository ErollementsObjeto = new EnrollementsRepository();
        Erollements erollements = new Erollements();



        // GET: Inscripcion
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult UnionDeTablas()
        {
            var join = ErollementsObjeto.UnionDeTablas();

            return View(join);
        }
    }
}