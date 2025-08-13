using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Menu_Principal;

namespace UTApp.Forms.Asignaciones
{
    public partial class FormAsignaciones : Form
    {
        public FormAsignaciones()
        {
            InitializeComponent();
        }

        private void FormAsignaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgregarAsignacion agregar = new AgregarAsignacion();
            agregar.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditarAsignacion editar = new EditarAsignacion();
            editar.Show();
            this.Hide();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
