using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Clases
{
    internal class Clase
    {
        int claseID;
        int docenteID;
        int materiaID;
        int grupoID;

        public Clase(int claseID, int docenteID, int grupoID, int materiaID)
        {
            this.claseID = claseID;
            this.docenteID = docenteID;
            this.materiaID = materiaID;
            this.grupoID = grupoID;
        }

        public int ClaseID { get => claseID; set => claseID = value; }
        public int DocenteID { get => docenteID; set => docenteID = value; }
        public int MateriaID { get => materiaID; set => materiaID = value; }
        public int GrupoID { get => grupoID; set => grupoID = value; }
    }
}
