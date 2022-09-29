using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarSelosPA.Modelo
{
    public class Resultado
    {
        public bool enviado { get; set; }
        public string qrcode { get; set; }

        public Resultado(bool enviado, string qrcode)
        {
            this.enviado = enviado;
            this.qrcode = qrcode;
        }

        public Resultado() {}
    }
}
