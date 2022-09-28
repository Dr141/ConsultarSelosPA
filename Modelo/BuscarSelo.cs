using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarSelosPA.Modelo
{
   public class BuscarSelo
    {
        public string BuscarSeloTJ(Selo selo)
        {
            try
            {
                WebRequest request = WebRequest.Create(
                   "https://apps.tjpa.jus.br/ValidaSeloDigital/Detalhes/Resultado?codigoSelo=" + selo.NumeroSelo +
                   "&serie=" + selo.SerieSelo + "&codigoTiposelo=" + selo.Tipo + "&codigoSeguranca=" + selo.CodigoSeguranca);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();

                //Stream dataStream = response.GetResponseStream();
                //// Open the stream using a StreamReader for easy access.
                //StreamReader reader = new StreamReader(dataStream);
                //// Read the content.
                //string responseFromServer = reader.ReadToEnd();
                //if (responseFromServer.Contains("data:image;base64"))
                //{
                //    tableLayoutPanel1.Controls.Add(new Label() { Text = numeroSelo.ToString() }, 0, A);
                //    this.sw.WriteLine(serie + " - " + tipo + this.validarSelos.tipoSelo(Int32.Parse(tipo)) + " - " + numeroSelo);
                //    A++;
                //}
                //else if (responseFromServer.Contains("Selo não encontrado para as informações abaixo:"))
                //{
                //    tableLayoutPanel1.Controls.Add(new Label() { Text = numeroSelo.ToString() }, 1, B);
                //    this.sw1.WriteLine(serie + " - " + tipo + this.validarSelos.tipoSelo(Int32.Parse(tipo)) + " - " + numeroSelo);
                //    B++;
                //}
                //else
                //{
                //    tableLayoutPanel1.Controls.Add(new Label() { Text = numeroSelo.ToString() }, 2, C);
                //    this.sw2.WriteLine(serie + " - " + tipo + this.validarSelos.tipoSelo(Int32.Parse(tipo)) + " - " + numeroSelo);
                //    C++;
                //}
                //response.Close();
                //progressBar1.PerformStep();
                //await Task.Delay(2000);
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return "";
            }
        }
    }
}
