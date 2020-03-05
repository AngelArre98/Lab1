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
    public class EliminarController : Controller
    {
        //
        // GET: /Eliminar/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(int IdVideo)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add( new SqlParameter("@Idvideo", IdVideo));

            BaseHelper.ejecutarSentencia("Delete from video where IdVideo = @Idvideo", CommandType.Text, parametros);
            
            
            return View();

        }




    }
}
