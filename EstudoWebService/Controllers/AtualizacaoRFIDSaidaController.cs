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
    [RoutePrefix("api/AtualizacaoRFIDSaida")]
    public class AtualizacaoRFIDSaidaController : ApiController
    {
        public JsonResult<bool> Get()
        {
            return Json(true);
        }

        [HttpPost]
        //[Route("Atualizar")]
        public JsonResult<bool> Atualizar(RFIDparametrosSaida parametros)
        {
            if (parametros != null)
            {
                try
                {
                    using (IDbConnection dbConn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        dbConn.Open();
                        dbConn.Execute($@"INSERT INTO [dbo].[RFIDSaida] ([Id],[Nome], [DataSaida]) VALUES (@Id,@Nome, @DataSaida)", new { Nome = parametros.Nome, DataSaida= parametros.DataSaida });
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

