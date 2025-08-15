using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Clases
{
    internal class Asignacion
    {
        int asignacionID;
        string asignacionTitulo;
        string asignacionDescripcion;
        DateTime asignacionFechaLimite;
        int claseID;
        int plataformaID;

        public int AsignacionID { get => asignacionID; set => asignacionID = value; }
        public string AsignacionTitulo { get => asignacionTitulo; set => asignacionTitulo = value; }
        public string AsignacionDescripcion { get => asignacionDescripcion; set => asignacionDescripcion = value; }
        public DateTime AsignacionFechaLimite { get => asignacionFechaLimite; set => asignacionFechaLimite = value; }
        public int ClaseID { get => claseID; set => claseID = value; }
        public int PlataformaID { get => plataformaID; set => plataformaID = value; }
        public Asignacion(int asignacionID, string asignacionTitulo, string asignacionDescripcion, DateTime asignacionFechaLimite, int claseID, int plataformaID)
        {
            this.asignacionID = asignacionID;
            this.asignacionTitulo = asignacionTitulo;
            this.asignacionDescripcion = asignacionDescripcion;
            this.asignacionFechaLimite = asignacionFechaLimite;
            this.claseID = claseID;
            this.plataformaID = plataformaID;
        }
    }
}
