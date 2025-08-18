using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Asignaciones;
using UTApp.Forms.Docentes;
using UTApp.Forms.Estudiantes;
using UTApp.Forms.Grupos;
using UTApp.Forms.Materias;

namespace UTApp.Forms.Menu_Principal
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void Menu_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            FormAsignaciones formAsignaciones = new FormAsignaciones();
            formAsignaciones.Show();
            this.Hide();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FormMaterias materias = new FormMaterias();
            this.Hide();
            materias.Show();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FormGrupos grupos = new FormGrupos();
            this.Hide();
            grupos.Show();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FormEstudiantes formEstudiantes = new FormEstudiantes();
            formEstudiantes.Show();
            this.Hide();
        }


        private void btnDocentes_Click(object sender, EventArgs e)
        {
            FormDocentes formDocentes = new FormDocentes();
            formDocentes.Show();
            this.Hide();
        }
    }
}
