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
        #region Variables
        private FormMaterias _formPadre;
        
        private MateriaBLL _materiaBLL;
        #endregion

        #region Constructors
        public FormEliminarMateria()
        {
            InitializeComponent();
            _materiaBLL = new MateriaBLL();
        }

        public FormEliminarMateria(FormMaterias formPadre) : this()
        {
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
        private void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            EliminarMateria();
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

        private void EliminarMateria()
        {
            int id = int.Parse(txtMateriaEliminadaID.Text);

            _materiaBLL.EliminarMateria(id);
        }
        #endregion

        private void FormEliminarMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void FormEliminarMateria_Load(object sender, EventArgs e)
        {

        }
    }
}
