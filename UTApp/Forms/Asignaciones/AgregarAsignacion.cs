using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp.Forms.Asignaciones
{
    public partial class AgregarAsignacion : Form
    {
        public AgregarAsignacion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAsignaciones asignaciones = new FormAsignaciones();
            asignaciones.Show();
            this.Close();
        }
    }
}
