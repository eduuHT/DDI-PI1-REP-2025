using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Clases
{
    internal class Plataforma
    {
        int plataformaID;
        string plataformaNombre;
        string plataformaURL;

        public Plataforma(int plataformaID, string plataformaNombre, string plataformaURL)
        {
            this.plataformaID = plataformaID;
            this.plataformaNombre = plataformaNombre;
            this.plataformaURL = plataformaURL;
        }

        public int PlataformaID { get => plataformaID; set => plataformaID = value; }
        public string PlataformaNombre { get => plataformaNombre; set => plataformaNombre = value; }
        public string PlataformaURL { get => plataformaURL; set => plataformaURL = value; }
    }
}
