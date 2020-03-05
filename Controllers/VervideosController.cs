using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VervideosController : Controller
    {
        //
        // GET: /Vervideos/

        public ActionResult Index()
        {

            ViewData["video"] = BaseHelper.ejecutarSentencia("Select * from video", CommandType.Text);
            return View();
        }
        [HttpPost]

        public ActionResult Mostrar()
        {
            

            return View();
        }

    }
}
