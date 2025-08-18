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
    public partial class FormEditarMateria : Form
    {
        #region Variables
        private FormMaterias _formPadre;

        private MateriaBLL _materiaBLL;
        #endregion

        #region Constructors
        public FormEditarMateria()
        {
            InitializeComponent();
            _materiaBLL = new MateriaBLL();
        }

        public FormEditarMateria(FormMaterias formPadre) : this()
        {
            _formPadre = formPadre;
        }
        #endregion

        #region Events

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Regresar();
        }
        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            EditarMateria();
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
        private void EditarMateria()
        {
            int id = int.Parse(txtMateriaEditadaID.Text);
            string nombre = txtNuevoNombre.Text;

            Materia materiaActualizada = new Materia
            {
                Id = id,
                Nombre = nombre,
            };

            _materiaBLL.ActualizarGrupo(materiaActualizada);
        }
        #endregion

    }
}
