using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTApp.Forms.Estudiantes
{
    internal class ClaseEstudianteID
    {
        private int estudianteID;
        private string estudianteMatricula;
        private string estudianteNombreCompleto;
        private string estudianteEmail;
        private string estudiantePassword;
        private int grupoID;

        public ClaseEstudianteID(int estudianteID, string estudianteMatricula, string estudianteNombreCompleto, string estudianteEmail, string estudiantePassword, int grupoID)
        {
            this.estudianteID = estudianteID;
            this.estudianteMatricula = estudianteMatricula;
            this.estudianteNombreCompleto = estudianteNombreCompleto;
            this.estudianteEmail = estudianteEmail;
            this.estudiantePassword = estudiantePassword;
            this.grupoID = grupoID;
        }

        public int EstudianteID { get => estudianteID; set => estudianteID = value; }
        public string EstudianteMatricula { get => estudianteMatricula; set => estudianteMatricula = value; }
        public string EstudianteNombreCompleto { get => estudianteNombreCompleto; set => estudianteNombreCompleto = value; }
        public string EstudianteEmail { get => estudianteEmail; set => estudianteEmail = value; }
        public string EstudiantePassword { get => estudiantePassword; set => estudiantePassword = value; }
        public int GrupoID { get => grupoID; set => grupoID = value; }
    }
}
