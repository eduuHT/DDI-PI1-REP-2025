using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTApp.Forms.Grupos
{
    public partial class FormGrupos : Form // Form Principal del Crud Grupos
    {
        #region Constructors
        public FormGrupos()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormAgregarGrupo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormEliminarGrupo();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormEditarGrupo();
        }
        #endregion

        #region Private Methods
        private void AbrirFormAgregarGrupo()
        {
            var formAgregarGrupo = new FormAgregarGrupo(this);  // Crear una instancia del form secundario y pasarle la instancia del form principal
            formAgregarGrupo.Show();
            this.Hide();
        }

        private void AbrirFormEliminarGrupo()
        {
            var formEliminarGrupo = new FormEliminarGrupo(this);  // Crear una instancia del form secundario y pasarle la instancia del form principal
            formEliminarGrupo.Show();
            this.Hide();
        }

        private void AbrirFormEditarGrupo()
        {
            var formEditarGrupo = new FormEditarGrupo(this);  // Crear una instancia del form secundario y pasarle la instancia del form principal
            formEditarGrupo.Show();
            this.Hide();
        }
        #endregion

    }
}
