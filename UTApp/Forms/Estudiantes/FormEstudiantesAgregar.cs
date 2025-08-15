using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp.Forms.Estudiantes
{
    public partial class FormEstudiantesAgregar : Form
    {
        public FormEstudiantesAgregar()
        {
            InitializeComponent();
        }

        private void FormEstudiantesAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
