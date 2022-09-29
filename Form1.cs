using ConsultarSelosPA.Modelo;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarSelosPA
{
    public partial class FormPrincipal : Form
    {
        public Selo selo { get; set; }
        public Resultado resul = new Resultado();
        BuscarSelo buscar = new BuscarSelo();
        public TipoSelo tipo { get; set; }
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
    }
}
