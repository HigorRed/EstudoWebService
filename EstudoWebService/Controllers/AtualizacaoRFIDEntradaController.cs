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
    [RoutePrefix("api/AtualizacaoRFIDEntrada")]
    public class AtualizacaoRFIDEntradaController : ApiController
    {
        public JsonResult<bool> Get()
        {
            return Json(true);
        }

        [HttpPost]
        //[Route("Atualizar")]
        public JsonResult<bool> Adicionar(RFIDparametrosEntrada parametros)
        {
            if (parametros != null)
            {
                try
                {
                    using (IDbConnection dbConn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        dbConn.Open();
                        dbConn.Execute($@"INSERT INTO [dbo].[Entrada] ([Nome],[Data],[Tag],[Umidade],[Temperatura]) VALUES (@Nome,@Data,@Tag,@Umidade,@Temperatura)",
                            new { Nome = parametros.Nome, Data = parametros.DataEntrada, Tag = parametros.Tag, Umidade = parametros.Umidade, Temperatura = parametros.Temperatura });
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

