using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarSelosPA.Modelo
{
   public class Selo
    {
        public string SerieSelo { get; set; }
        public string Tipo { get; set; }
        public string CodigoSeguranca { get; set; }
        public string NumeroSelo { get; set; }

        public Selo(string serie, string tipo, string codigo, string selo)
        {
            this.CodigoSeguranca = codigo;
            this.Tipo            = tipo;
            this.SerieSelo       = serie;
            this.NumeroSelo      = selo;
        }

        public Selo() {}

        public bool Vazio()
        {
            if(SerieSelo       != null &&
               Tipo            != null &&
               NumeroSelo      != null &&
               CodigoSeguranca != null
              ) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
