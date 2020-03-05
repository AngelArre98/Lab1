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
    public class AgregarController : Controller
    {
        //
        // GET: /Agregar/

        public ActionResult Index()
        {
            return View();
        }

    [HttpPost]
        public ActionResult Index( int IdVideo, string titulo, int repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarConsulta("Insert into video values(@IdVideo,@titulo,@repro,@url)",CommandType.Text,parametros);
            return View();
        }

    }
}
