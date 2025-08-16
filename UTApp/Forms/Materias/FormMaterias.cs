using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp.Forms.Materias
{
    public partial class FormMaterias : Form
    {

        #region Constructors
        public FormMaterias()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormAgregarMateria();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormEliminarMateria();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormEditarMateria();
        }

        #endregion

        #region Private Methods
        private void AbrirFormAgregarMateria()
        {
            var formAgregarMateria = new FormAgregarMateria(this);
            formAgregarMateria.Show();
            this.Hide();
        }
        private void AbrirFormEliminarMateria()
        {
            var formEliminarMateria = new FormEliminarMateria(this);
            formEliminarMateria.Show();
            this.Hide();
        }
        private void AbrirFormEditarMateria()
        {
            var formEditarMateria = new FormEditarMateria(this);
            formEditarMateria.Show();
            this.Hide();
        }
        #endregion
    }
}
