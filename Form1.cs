using ConsultarSelosPA.Modelo;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarSelosPA
{
    public partial class FormPrincipal : Form
    {
        public Selo selo { get; set; }
        public Resultado resul = new Resultado();
        BuscarSelo buscar = new BuscarSelo();
        public TipoSelo tipo = new TipoSelo();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            tipo = new TipoSelo();
            var address = "https://apps.tjpa.jus.br/ValidaSeloDigital/Detalhes/Resultado?codigoSelo=" +
                   $"{tBNumeroS.Text}&serie={cBSerie.Text}&codigoTiposelo={tipo.CodigoTipoSelo(cBTipo.Text)}&codigoSeguranca={tBSeguraca.Text}";
            wBrowser.Navigate(new System.Uri(address));

           //  selo = new Selo("A", "111", "05488000000010116544316060", "88450");
           //await buscar.VerificarSelos(selo, resul);

           //var a = resul.qrcode;

           //var b = resul.enviado;
        }

        private void buttLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            tBNumeroS.Text  = "";
            tBSeguraca.Text = "";
            cBSerie.SelectedIndex = -1;
            cBTipo.SelectedIndex = -1;

            wBrowser.Dispose();
        }

        private void buttSeleciona_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Selecionar csv";

            openFileDialog.InitialDirectory = @"";

            openFileDialog.Filter = "(*.csv)|*.csv";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            DialogResult dr = this.openFileDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                tBCaminho.Text += openFileDialog.FileName;
            }
        }


        private void habilitarbuttLimpar2(bool valor)
        {
            buttLimpar2.Enabled = valor;
        }

        private void tBCaminho_TextChanged(object sender, System.EventArgs e)
        {
            if(tBCaminho.Text != "")
            {
                habilitarbuttLimpar2(true);
            }
            else
            {
                habilitarbuttLimpar2(false);
            }
        }

        private async void buttIniciar_MouseClick(object sender, MouseEventArgs e)
        {
            listView.Clear();

            Arquivo arquivo = new Arquivo();
            List<Selo> selos = arquivo.selo(tBCaminho.Text);
            var A = 0;
            var B = 0;

            foreach (Selo selo in selos)
            {
               await buscar.VerificarSelos(selo, resul);

                if (!resul.enviado)
                {
                    listView.Columns.Add(selo.NumeroSelo, tipo.DescricaoTipoSelo(int.Parse(selo.Tipo)));
                }
                else
                {
                    listViewEnvi.Items.Add(selo.NumeroSelo,A);
                    A++;
                }
            }
        }
    }
}
