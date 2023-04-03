using System;
using System.Collections.Generic;
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


            // Cria uma conexão com o banco de dados
            SqlConnection connection = new SqlConnection("Data Source=.;Integrated Security=SSPI; Initial Catalog=EstudoJornada");

            // Cria uma consulta SQL para obter as informações do cartão
            string sqlQuery = "SELECT Empresa, Unidade, Data, Temperatura, Umidade, Presentes FROM Teste";

            // Cria um objeto Command para executar a consulta SQL
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            // Abre a conexão com o banco de dados
            connection.Open();

            // Executa a consulta SQL e obtém um objeto DataReader para ler os resultados
            SqlDataReader reader = command.ExecuteReader();

            // Verifica se há linhas de dados retornadas
            if (reader.HasRows)
            {
                // Lê os dados da primeira linha do resultado da consulta
                reader.Read();

                // Atualiza o conteúdo do cartão com as informações obtidas do banco de dados
                empresaLabel.Text = reader.GetString(0);
                unidadeLabel.Text = reader.GetString(1);
                dataLabel.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy HH:mm:ss");
                temperaturaLabel.Text = reader.GetDouble(3).ToString();
                umidadeLabel.Text = reader.GetDouble(4).ToString();

                // Converte a lista de presentes em uma lista de strings
                List<string> presentes = new List<string>();
                string[] nomes = reader.GetString(5).Split(',');
                foreach (string nome in nomes)
                {
                    presentes.Add(nome.Trim());
                }

                // Atualiza o conteúdo da lista de presentes com as informações obtidas do banco de dados
                presentesList.DataSource = presentes;
                presentesList.DataBind();
            }

            // Fecha o objeto DataReader e a conexão com o banco de dados
            reader.Close();
            connection.Close();
        }
    }
}
