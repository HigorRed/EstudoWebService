using Dapper;
using EstudoWebService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstudoWebService
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var entradas = connection.Query<RFIDparametrosEntrada>("SELECT tag, nome, temperatura, umidade, data FROM entrada ORDER BY Data Desc").FirstOrDefault();

                    if (entradas != null)
                    {

                        tagLabel.Text = entradas.Tag;
                        NomeLabel.Text = entradas.Nome;
                        temperaturaLabel.Text = entradas.Temperatura.ToString();
                        umidadeLabel.Text = entradas.Umidade.ToString();
                        DataLabel.Text = entradas.Data.ToString("dd/MM/yyyy HH:mm:ss");

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}







