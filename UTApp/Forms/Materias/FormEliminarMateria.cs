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
    public partial class FormEliminarMateria : Form
    {
        private FormMaterias _formPadre;

        #region Constructors
        public FormEliminarMateria()
        {
            InitializeComponent();
        }

        public FormEliminarMateria(FormMaterias formPadre)
        {
            InitializeComponent();
            _formPadre = formPadre;
        }
        #endregion

        #region Events
        private void btnCancelarEliminacion_Click(object sender, EventArgs e)
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
            _formPadre.Show();
            this.Close();
        }
        #endregion

    }
}
