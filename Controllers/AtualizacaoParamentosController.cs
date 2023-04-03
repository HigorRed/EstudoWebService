using EstudoWebService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Dapper;

namespace EstudoWebService.Controllers
{
    [RoutePrefix("api/AtualizacaoParamentos")]
    public class AtualizacaoParamentosController : ApiController
    {
        public JsonResult<bool> Get()
        {
            return Json(true);
        }

        [HttpPost]
        //[Route("Atualizar")]
        public JsonResult<bool> Atualizar(ParamentrosESP32 parametros)
        {
            if (parametros != null)
            {
                try
                {
                    using (IDbConnection dbConn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        dbConn.Open();
                         dbConn.Execute($@"INSERT INTO [dbo].[ParametrosEsp32] ([Data],[Temperatura],[Umidade]) VALUES (@Data,@Temperatura,@Umidade)", new { Data = parametros.Data, Temperatura = parametros.Temperatura, Umidade = parametros.Umidade });
                        return Json(true);
                    }
                }
                catch (Exception)
                {
                    return Json(false);
                }
            }

            return Json(false);
        }

    }
}
