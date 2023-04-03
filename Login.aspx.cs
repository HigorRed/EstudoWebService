﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Senha", senha);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    Response.Redirect("Default1.aspx");
                }
                else
                {
                    // exibe uma mensagem de erro para o usuário
                    Response.Write("<script>alert('Usuário ou senha inválidos.');</script>");
                }
            }
        }
    }
}