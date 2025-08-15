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
        private FormGrupos _formPadre; // Variable para la instancia original del form Grupos

        #region Constructors
        public FormEditarGrupo()
        {
            InitializeComponent();
        }

        public FormEditarGrupo(FormGrupos formPadre) // Overload que toma la instancia del form original de Grupos y la asigna a la variable _formPadre
        {
            InitializeComponent();
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
