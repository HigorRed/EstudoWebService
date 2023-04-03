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
                var result = connection.QuerySingle<Teste>("SELECT Empresa, Unidade, Data, Temperatura, Umidade, Presentes FROM Teste");

                // Atualiza o conteúdo do cartão com as informações obtidas do banco de dados
                empresaLabel.Text = result.Empresa;
                unidadeLabel.Text = result.Unidade;
                dataLabel.Text = result.Data.ToString("dd/MM/yyyy HH:mm:ss");
                temperaturaLabel.Text = result.Temperatura.ToString();
                umidadeLabel.Text = result.Umidade.ToString();

                // Converte a lista de presentes em uma lista de strings
                List<string> presentes = new List<string>();
                string[] nomes = result.Presentes.Split(',');
                foreach (string nome in nomes)
                {
                    presentes.Add(nome.Trim());
                }

                // Atualiza o conteúdo da lista de presentes com as informações obtidas do banco de dados
                presentesList.DataSource = presentes;
                presentesList.DataBind();
            }
        }
    }
}
