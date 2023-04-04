using Dapper;
using EstudoWebService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace EstudoWebService.Controllers
{

    [RoutePrefix("api/AtualizaçãoRFIDEntrada")]
    public class AtualizacaoRFIDEntradaController : ApiController
    {
        public JsonResult<bool> Get()
        {
            return Json(true);
        }

        [HttpPost]
        //[Route("Atualizar")]
        public JsonResult<bool> Atualizar(RFIDparametrosEntrada parametros)
        {
            if (parametros != null)
            {
                try
                {
                    using (IDbConnection dbConn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        dbConn.Open();
                        dbConn.Execute($@"INSERT INTO [dbo].[RFIDEntrada] ([Nome],[DataEntrada]) VALUES (@Nome,@DataEntrada)", new { Nome = parametros.Nome, DataEntrada = parametros.DataEntrada });
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
