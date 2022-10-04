using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarSelosPA.Modelo
{
    public class Arquivo
    {
        public int Total { get; private set; }
        public string Linha { get; private set; }
        public FileStream file;
        StreamReader sr;

        public int QuantidadeLinha(string caminho)
        {
            try
            {
               file = new FileStream(caminho, FileMode.Open);
               sr = new StreamReader(file);
               while ((Linha = sr.ReadLine()) != null)
               {
                    Total++;
               }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            file.Close();
            sr.Close();

            return Total;
        }

        public List<Selo> selo(string caminho)
        {
            Selo selo = new Selo();
            List<Selo> seloList = new List<Selo>();

            try
            {
                file = new FileStream(caminho, FileMode.Open);
                sr = new StreamReader(file);

                while ((Linha = sr.ReadLine()) != null)
                {
                    foreach (string y in Linha.Split(','))
                    {
                        if (y == "A" || y == "B" || y == "C" || y == "D")
                            selo.SerieSelo = y;
                        if (y.Length == 3 && !(y.StartsWith("T") || y.StartsWith("t")))
                            selo.Tipo = y;
                        if (y.Length > 20 && !(y.StartsWith("C") || y.StartsWith("c")))
                            selo.CodigoSeguranca = y;
                        if (y.Length > 3 && y.Length < 20 && !(y.StartsWith("N") || y.StartsWith("n") || y.StartsWith("C") || y.StartsWith("c")
                            || y.StartsWith("T") || y.StartsWith("t") || y.StartsWith("S") || y.StartsWith("s")))
                            selo.NumeroSelo = y;
                    }

                    if (selo.Vazio()) 
                    {
                        seloList.Add(new Selo()
                        {
                            SerieSelo = selo.SerieSelo,
                            Tipo = selo.Tipo,
                            CodigoSeguranca = selo.CodigoSeguranca,
                            NumeroSelo = selo.NumeroSelo
                        });
                    }                    
                }

                file.Close();
                sr.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return seloList;
        }
    }
}
