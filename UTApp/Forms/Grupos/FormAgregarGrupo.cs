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
    public partial class FormAgregarGrupo : Form // Form Secundario del Crud Grupos
    {
        #region Variables
        private FormGrupos _formPadre; // Variable para la instancia original del form Grupos

        private GrupoBLL _grupoBLL; // Variable para instancia de la capa de Lógica de Negocio
        #endregion

        #region Constructors
        public FormAgregarGrupo()
        {
            InitializeComponent();
            _grupoBLL = new GrupoBLL();
        }

        public FormAgregarGrupo(FormGrupos formPadre) : this()// Overload que toma la instancia del form original de Grupos y la asigna a la variable _formPadre
        {
            _formPadre = formPadre;
        }

        #endregion

        #region Events
        private void btnCancelarAdicion_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Regresar();
        }
        private void btnConfirmarAdicion_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.Nombre = txtNombreGrupo.Text;

            _grupoBLL.GuardarGrupo(grupo);
        }
        #endregion

        #region Private Methods
        private void Regresar()
        {
            // mostrar de nuevo el form principal y ocultar este form secundario
            _formPadre.Show();
            this.Close();
        }

        #endregion

    }
}
