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
    [RoutePrefix("api/AtualizacaoRFIDSaida")]
    public class AtualizacaoRFIDSaidaController : ApiController
    {
        public JsonResult<bool> Get()
        {
            return Json(true);
        }

        [HttpPost]
        //[Route("Atualizar")]
        public JsonResult<bool> Inserir(RFIDparametrosSaida parametros)
        {
            if (parametros != null)
            {
                try
                {
                    using (IDbConnection dbConn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        dbConn.Open();
                        dbConn.Execute($@"INSERT INTO [dbo].[SAIDA] ([Nome],[Data],[Tag]) VALUES (@Nome,@Data,@Tag)",
                            new {Nome=parametros.Nome, Data = parametros.Data, Tag= parametros.Tag });
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

