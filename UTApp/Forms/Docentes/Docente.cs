using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Forms.Docentes
{
    internal class Docente
    {
        private string docenteNumeroEmpleado;
        private string docenteNombreCompleto;
        private string docenteTituloAcademico;
        private string docenteEmail;
        private string docentePassword;

        public Docente()
        {

        }

        public Docente(string docenteNumeroEmpleado, string docenteNombreCompleto, string docenteTituloAcademico, string docenteEmail, string docentePassword)
        {
            this.docenteNumeroEmpleado = docenteNumeroEmpleado;
            this.docenteNombreCompleto = docenteNombreCompleto;
            this.docenteTituloAcademico = docenteTituloAcademico;
            this.docenteEmail = docenteEmail;
            this.docentePassword = docentePassword;
        }

        public string DocenteNumeroEmpleado { get => docenteNumeroEmpleado; set => docenteNumeroEmpleado = value; }
        public string DocenteNombreCompleto { get => docenteNombreCompleto; set => docenteNombreCompleto = value; }
        public string DocenteTituloAcademico { get => docenteTituloAcademico; set => docenteTituloAcademico = value; }
        public string DocenteEmail { get => docenteEmail; set => docenteEmail = value; }
        public string DocentePassword { get => docentePassword; set => docentePassword = value; }
    }
}
