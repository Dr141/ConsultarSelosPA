using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarSelosPA.Modelo
{
   public class BuscarSelo
   {
        static readonly HttpClient client = new HttpClient();

        public static async Task BuscarSeloTJ(Selo selo, Resultado resul)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(
                   "https://apps.tjpa.jus.br/ValidaSeloDigital/Detalhes/Resultado?codigoSelo=" +
                   $"{selo.NumeroSelo}&serie={selo.SerieSelo}&codigoTiposelo={selo.Tipo}&codigoSeguranca={selo.CodigoSeguranca}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                resul.enviado = responseBody.Contains("data:image;base64");
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(e.Message,
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resul = new Resultado(false, "");
            }
        }

        public async Task VerificarSelos(Selo selo, Resultado resul)
        {
            await BuscarSeloTJ(selo, resul);
        }

        public static string Qrcode(string body)
        {
            if (body != "")
            {
                body = body.Substring(body.IndexOf("data:image;base64,") + 18);
                body = body.Substring(0, body.IndexOf("/>") - 2);
            }

            return body;
        }
   }
}
