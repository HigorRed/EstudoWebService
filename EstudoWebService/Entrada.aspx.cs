using EstudoWebService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstudoWebService
{
    public partial class Entrada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SimularEnvioParamentos_Click(object sender, EventArgs e)
        {
            SimularChamada();
        }

        private async void SimularChamada()
        {
            //criar o cliente de comunicacao
            var client = new HttpClient(new HttpClientHandler());
            client.Timeout = new TimeSpan(0, 30, 0);


            var paramentoTeste = new RFIDparametrosEntrada()
            {
                Tag=txtTag.Text,
                Nome=txtNome.Text,
                DataEntrada = DateTime.Now,
                Temperatura = decimal.Parse(txtTemp.Text),
                Umidade = decimal.Parse(txtUmid.Text),
            };

            var serialized = JsonConvert.SerializeObject(paramentoTeste);

            var body = new StringContent(serialized, Encoding.UTF8, "application/json");
            //http://servidor/api/AtualizacaoParamentos/Atualizar
            var httpResponse = await client.PostAsync($"https://{Context.Request.Url.Host}:{Context.Request.Url.Port}/api/AtualizacaoRFIDEntrada/Adicionar", body);

            var result = await httpResponse.Content.ReadAsStringAsync();


            lblResultado.Text = result;
            //editando
        }
    }
}