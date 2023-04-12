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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var saidas = connection.Query<RFIDparametrosSaida>("SELECT DISTINCT TOP 10 tag, nome, data FROM SAIDA ORDER BY data DESC");

                    int i = 1;
                    foreach (var saida in saidas)
                    {
                        switch (i)
                        {
                            case 1:
                                tagLabel1.InnerText = saida.Tag;
                                NomeLabel1.InnerText = saida.Nome;
                                DataLabel1.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 2:
                                tagLabel2.InnerText = saida.Tag;
                                NomeLabel2.InnerText = saida.Nome;
                                DataLabel2.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 3:
                                tagLabel3.InnerText = saida.Tag;
                                NomeLabel3.InnerText = saida.Nome;
                                DataLabel3.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 4:
                                tagLabel4.InnerText = saida.Tag;
                                NomeLabel4.InnerText = saida.Nome;
                                DataLabel4.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 5:
                                tagLabel5.InnerText = saida.Tag;
                                NomeLabel5.InnerText = saida.Nome;
                                DataLabel5.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 6:
                                tagLabel6.InnerText = saida.Tag;
                                NomeLabel6.InnerText = saida.Nome;
                                DataLabel6.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 7:
                                tagLabel7.InnerText = saida.Tag;
                                NomeLabel7.InnerText = saida.Nome;
                                DataLabel7.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 8:
                                tagLabel8.InnerText = saida.Tag;
                                NomeLabel8.InnerText = saida.Nome;
                                DataLabel8.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 9:
                                tagLabel9.InnerText = saida.Tag;
                                NomeLabel9.InnerText = saida.Nome;
                                DataLabel9.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                            case 10:
                                tagLabel10.InnerText = saida.Tag;
                                NomeLabel10.InnerText = saida.Nome;
                                DataLabel10.InnerText = saida.Data.ToString("dd/MM/yyyy HH:mm:ss");
                                break;
                        }
                        i++;
                    }
                }
                catch (Exception ex)
                {
                   
                }
            }
        }
    }
}