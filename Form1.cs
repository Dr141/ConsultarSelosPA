using ConsultarSelosPA.Modelo;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_log;

namespace ConsultarSelosPA
{
    public partial class FormPrincipal : Form
    {
        public Selo selo { get; set; }
        public Resultado resul = new Resultado();
        BuscarSelo buscar = new BuscarSelo();
        public TipoSelo tipo = new TipoSelo();
        public List<string> NaoEnviado = new List<string>();

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
            buttIniciar.Enabled = valor;
        }

        private void tBCaminho_TextChanged(object sender, System.EventArgs e)
        {
            if(tBCaminho.Text != "")
            {
                habilitarbuttLimpar2(true);
                tBCaminho.Enabled = false;
            }
            else
            {
                habilitarbuttLimpar2(false);
                tBCaminho.Enabled = true;
            }
        }

        private async void buttIniciar_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridViewR.Rows.Clear();
            dataGridViewEnviado.Rows.Clear();

            Arquivo arquivo = new Arquivo();
            List<Selo> selos = arquivo.selo(tBCaminho.Text);
            pBar.Maximum = selos.Count;
            pBar.Step = 1;
            pBar.Value = 0;

            foreach (Selo selo in selos)
            {
                await buscar.VerificarSelos(selo, resul);                

                if (!resul.enviado)
                {
                    dataGridViewR.Rows.Add(selo.NumeroSelo, tipo.DescricaoTipoSelo(int.Parse(selo.Tipo)));
                    NaoEnviado.Add(selo.NumeroSelo + ","+ tipo.DescricaoTipoSelo(int.Parse(selo.Tipo)));
                }
                else
                {
                    dataGridViewEnviado.Rows.Add(selo.NumeroSelo);
                }

                pBar.PerformStep();

                HabilitabuttExportar(dataGridViewR.RowCount);
            }
        }

        private void HabilitabuttExportar(int cont)
        {
            if ( cont > 0)
            {
                buttExportar.Enabled = true;
            }
            else
            {
                buttExportar.Enabled = false;
            }
        }

        private void buttLimpar2_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente limpar os campos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                dataGridViewR.Rows.Clear();
                dataGridViewEnviado.Rows.Clear();
                tBCaminho.Text = "";
                habilitarbuttLimpar2(false);
                buttExportar.Enabled = false;
                pBar.Value = 0;
                pBar.Step = 0;
                pBar.PerformStep();
            }            
        }

        private void buttExportar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente salvar o resultado?", 
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                GerarCSV csv = new GerarCSV();
                csv.EscreverCSV(NaoEnviado);

                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                prc.Start();
            }            
        }
    }
}
