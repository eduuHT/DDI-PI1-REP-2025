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

namespace UTApp.Forms.Grupos
{
    public partial class FormGrupos : Form // Form Principal del Crud Grupos
    {
        private GrupoBLL _grupoBLL;

        #region Constructors
        public FormGrupos()
        {
            InitializeComponent();
            _grupoBLL = new GrupoBLL();
        }
        #endregion

        #region Events
        private void FormGrupos_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarGrid(txtBusqueda.Text);
            txtBusqueda.Text = string.Empty;
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
        public void LlenarGrid(string busquedaText = null)
        {
            List<Grupo> grupos = _grupoBLL.ObtenerGrupos(busquedaText);
            gridGrupos.DataSource = grupos;
        }

        #endregion

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal back = new FormMenuPrincipal();
            back.Show();
            this.Hide();
        }

        private void FormGrupos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
