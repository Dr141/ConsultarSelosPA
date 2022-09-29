using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarSelosPA.Modelo
{
    public class TipoSelo
    {
        public string DescricaoTipoSelo(int codigo)
        {
            switch (codigo)
            {
                case 101:
                    return " SELO DIGITAL GERAL";
                case 102:
                    return " SELO DIGITAL GRATUITO";
                case 104:
                    return " SELO DIGITAL RECONHECIMENTO";
                case 105:
                    return " SELO DIGITAL AUTENTICAÇÃO";
                case 106:
                    return " SELO DIGITAL CERTIDÃO";
                case 107:
                    return " SELO DIGITAL PROCURAÇÃO PÚBLICA";
                case 108:
                    return " SELO DIGITAL ESCRITURA PÚBLICA";
                case 109:
                    return " SELO DIGITAL CERTIDÃO DE NASCIMENTO 1ª VIA";
                case 110:
                    return " SELO DIGITAL CERTIDÃO DE ÓBITO 1ª VIA";
                case 111:
                    return " SELO DIGITAL CERTIDÃO DE NASCIMENTO 2ª VIA";
                case 112:
                    return " SELO DIGITAL CERTIDÃO DE ÓBITO 2ª VIA";
                case 113:
                    return " SELO DIGITAL DE POSTECIPAÇÃO";
                default:
                    return " SELO DIGITAL NÃO ENCONTRADO";
            }
        }

        public int CodigoTipoSelo(string descricao)
        {
            switch (descricao)
            {
                case "SELO DIGITAL GERAL":
                    return 101;
                case "SELO DIGITAL GRATUITO":
                    return 102;
                case "SELO DIGITAL RECONHECIMENTO":
                    return 104;
                case "SELO DIGITAL AUTENTICAÇÃO":
                    return 105;
                case "SELO DIGITAL CERTIDÃO":
                    return 106;
                case "SELO DIGITAL PROCURAÇÃO PÚBLICA":
                    return 107;
                case "SELO DIGITAL ESCRITURA PÚBLICA":
                    return 108;
                case "SELO DIGITAL CERTIDÃO DE NASCIMENTO 1ª VIA":
                    return 109;
                case "SELO DIGITAL CERTIDÃO DE ÓBITO 1ª VIA":
                    return 110;
                case "SELO DIGITAL CERTIDÃO DE NASCIMENTO 2ª VIA":
                    return 111;
                case "SELO DIGITAL CERTIDÃO DE ÓBITO 2ª VIA":
                    return 112;
                case "SELO DIGITAL DE POSTECIPAÇÃO":
                    return 113;
                default:
                    return 0;
            }
        }
    }
}
