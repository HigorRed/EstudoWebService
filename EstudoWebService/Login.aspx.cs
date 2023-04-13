using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstudoWebService
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEntrar_ServerClick(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Value.Trim();
            string senha = txtSenha.Value.Trim();

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT COUNT(*) FROM Login WHERE Usuario = @Usuario AND Senha = @Senha";


            var dbFile = HttpContext.Current.Server.MapPath("~/App_Data/BaseDadoLocal.db");

            try
            {
                using (IDbConnection dbConn = new SQLiteConnection($"Data Source={dbFile}; Version=3;"))//new SqlConnection(connectionString))
                {
                    dbConn.Open();
                    var contagem = dbConn.QueryFirstOrDefault<int>(query, new { Usuario = usuario, Senha = senha });


                    if (contagem > 0)
                        Response.Redirect("Default1.aspx");
                    else
                        // exibe uma mensagem de erro para o usuário
                        Response.Write("<script>alert('Usuário ou senha inválidos.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('{ex.Message}');</script>");
            }
        }
    }
}