using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Clases;
using UTApp.Forms.Menu_Principal;
using Microsoft.VisualBasic;

namespace UTApp.Forms.Asignaciones
{
    public partial class FormAsignaciones : Form
    {
        AsignacionControlador controlador = new AsignacionControlador();
        List<Asignacion> asignaciones = new List<Asignacion>();
        Asignacion actual = null;
        public FormAsignaciones()
        {
            InitializeComponent();
        }

        private void FormAsignaciones_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        public void ActualizarGrid(DataTable tabla)
        {
            gridAsignaciones.DataSource = null;
            gridAsignaciones.DataSource = tabla;
        }
        public void LlenarGrid()
        {
            asignaciones = controlador.ListarAsignaciones();
            gridAsignaciones.DataSource = asignaciones;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgregarAsignacion agregar = new AgregarAsignacion();
            agregar.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (actual != null)
            {
                if (MessageBox.Show($"¿SEGURO QUE QUIERE ELIMINAR '{actual.AsignacionTitulo}'?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (controlador.EliminarAsignacion(actual.AsignacionID))
                    {
                        MessageBox.Show("La asignación se ha eliminado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actual = null;
                        LlenarGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una asignacion primero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (actual != null)
            {
                EditarAsignacion editar = new EditarAsignacion(actual);
                editar.Show();
                this.Hide();
            }
             else
            {
                MessageBox.Show("Seleccione una asignacion primero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void btnScan_Click(object sender, EventArgs e)
        {
            ModoBusqueda modoBusqueda = new ModoBusqueda(this);
            modoBusqueda.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            this.Hide();
            menuPrincipal.Show();
        }

        private void FormAsignaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gridAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridAsignaciones.Rows.Count > 0 && e.RowIndex >= 0)
            {
                DataGridViewRow fila = gridAsignaciones.Rows[e.RowIndex];

                actual = new Asignacion(
                    Convert.ToInt32(fila.Cells[0].Value),
                    fila.Cells[1].Value.ToString(),
                    fila.Cells[2].Value.ToString(),
                    Convert.ToDateTime(fila.Cells[3].Value),
                    Convert.ToInt32(fila.Cells[4].Value),
                    Convert.ToInt32(fila.Cells[5].Value)
                );
            }
        }
    }
}
