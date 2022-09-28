using ConsultarSelosPA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarSelosPA
{
    public partial class FormPrincipal : Form
    {
        public Selo selo;
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            BuscarSelo buscar = new BuscarSelo();
            selo = new Selo("A", "111", "05488000000010116544316060", "88450");
            buscar.BuscarSeloTJ(selo);
        }
    }
}
