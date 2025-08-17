using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Forms.Docentes
{
    internal class ClaseDocenteID
    {
        private int docenteID;
        private string docenteNumeroEmpleado;
        private string docenteNombreCompleto;
        private string docenteTituloAcademico;
        private string docenteEmail;
        private string docentePassword;

        public ClaseDocenteID()
        {

        }

        public ClaseDocenteID(int docenteID, string docenteNumeroEmpleado, string docenteNombreCompleto, string docenteTituloAcademico, string docenteEmail, string docentePassword)
        {
            this.docenteID = docenteID;
            this.docenteNumeroEmpleado = docenteNumeroEmpleado;
            this.docenteNombreCompleto = docenteNombreCompleto;
            this.docenteTituloAcademico = docenteTituloAcademico;
            this.docenteEmail = docenteEmail;
            this.docentePassword = docentePassword;
        }

        public int DocenteID { get => docenteID; set => docenteID = value; }
        public string DocenteNumeroEmpleado { get => docenteNumeroEmpleado; set => docenteNumeroEmpleado = value; }
        public string DocenteNombreCompleto { get => docenteNombreCompleto; set => docenteNombreCompleto = value; }
        public string DocenteTituloAcademico { get => docenteTituloAcademico; set => docenteTituloAcademico = value; }
        public string DocenteEmail { get => docenteEmail; set => docenteEmail = value; }
        public string DocentePassword { get => docentePassword; set => docentePassword = value; }
    }
}
