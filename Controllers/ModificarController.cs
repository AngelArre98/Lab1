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
    public class ModificarController : Controller
    {
        //
        // GET: /Modificar/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(int Idvideo, string titulo, int repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", Idvideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("UPDATE video SET IdVideo = @IdVideo, titulo = @titulo, repro = @repro, url = @url WHERE IdVideo = @Idvideo", CommandType.Text, parametros);

            return View();
        }

    }
}
