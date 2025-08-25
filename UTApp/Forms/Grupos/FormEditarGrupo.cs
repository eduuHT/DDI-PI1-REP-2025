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
    public partial class FormEditarGrupo : Form
    {
        #region Variables
        private FormGrupos _formPadre; // Variable para la instancia original del form Grupos

        private GrupoBLL _grupoBLL;
        #endregion

        #region Constructors
        public FormEditarGrupo()
        {
            InitializeComponent();
            _grupoBLL = new GrupoBLL();
        }

        public FormEditarGrupo(FormGrupos formPadre) : this()// Overload que toma la instancia del form original de Grupos y la asigna a la variable _formPadre
        {
            _formPadre = formPadre;
        }

        #endregion

        #region Events
        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Regresar();
        }
        
        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            EditarGrupo();
            Regresar();
        }
        #endregion

        #region Private Methods
        private void Regresar()
        {
            // mostrar de nuevo el form principal y ocultar este form secundario
            _formPadre.Show();
            _formPadre.LlenarGrid();
            this.Close();
        }

        private void EditarGrupo()
        {
            // Obtener los datos editados desde los controles del formulario
            int id = int.Parse(txtGrupoEditadoID.Text);
            string nombre = txtNuevoNombre.Text;

            // Crear el objeto Grupo con los datos actualizados
            Grupo grupoActualizado = new Grupo
            {
                Id = id,
                Nombre = nombre
            };

            _grupoBLL.ActualizarGrupo(grupoActualizado);
        }


        #endregion

        private void FormEditarGrupo_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void FormEditarGrupo_Load(object sender, EventArgs e)
        {

        }
    }
}
