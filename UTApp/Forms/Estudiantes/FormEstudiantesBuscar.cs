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
    public partial class FormEstudiantesBuscar : Form
    {
        public FormEstudiantesBuscar()
        {
            InitializeComponent();
        }

        private void FormEstudiantesBuscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
