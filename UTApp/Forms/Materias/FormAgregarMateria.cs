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
    public partial class FormAgregarMateria : Form
    {
        #region Variables
        private FormMaterias _formPadre;

        private MateriaBLL _materiaBLL;
        #endregion

        #region Constructors
        public FormAgregarMateria()
        {
            InitializeComponent();
            _materiaBLL = new MateriaBLL();
        }

        public FormAgregarMateria(FormMaterias formPadre) : this()
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
            GuardarMateria();
            Regresar();
        }
        #endregion

        #region Private Methods
        private void Regresar()
        {
            _formPadre.Show();
            _formPadre.LlenarGrid();
            this.Close();
        }

        private void GuardarMateria()
        {
            Materia materia = new Materia();
            materia.Nombre = txtNombreMateria.Text;

            _materiaBLL.GuardarMateria(materia);
        }
        #endregion

        private void FormAgregarMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
