using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp.Forms.Docentes
{
    public partial class FormDocentesEditar : Form
    {
        public FormDocentesEditar()
        {
            InitializeComponent();
        }

        private void FormDocentesEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
