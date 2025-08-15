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
    public partial class EditarAsignacion : Form
    {
        public EditarAsignacion()
        {
            InitializeComponent();
        }

        private void lblAsignaciones_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAsignaciones asignaciones = new FormAsignaciones();
            asignaciones.Show();
            this.Hide();
        }

        private void EditarAsignacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EditarAsignacion_Load(object sender, EventArgs e) // tmb asigna las propiedades una vez hechos los demás cruds
        {
            /*
            CBDocente.DisplayMember = ;
            CBDocente.ValueMember =;
            CBGrupo.DisplayMember =;
            CBGrupo.ValueMember =;
            CBMateria.DisplayMember = ;
            CBMateria.ValueMember =;
            CBPlataforma.DisplayMember =;
            CBPlataforma.ValueMember =;*/
        }
        public void LlenarCampos() // Acuerdate de modificarla para llenarla con el click del grid
        {
            txtDescripcion.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            CBGrupo.Text = string.Empty;
            CBDocente.Text = string.Empty;
            CBMateria.Text = string.Empty;
            CBPlataforma.Text = string.Empty;
            DTEntrega.Text = string.Empty;
        }
        public bool ValidarCampos()
        {
            if (!string.IsNullOrEmpty(txtTitulo.Text) &&
                CBGrupo.SelectedIndex > -1 &&
                CBDocente.SelectedIndex > -1 &&
                CBMateria.SelectedIndex > -1 &&
                CBPlataforma.SelectedIndex > -1 &&
                DTEntrega.Value > DateTime.Now &&
                DTEntrega.Checked
                )
            {
                return true;
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
