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
            gridAsignaciones.DataSource = asignaciones;
        }
        public void LlenarGrid()
        {
            asignaciones = controlador.ListarAsignaciones();
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
                        this.asignacionTableAdapter.Fill(this.uTApp_Integradora1DataSet.Asignacion);
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
            EditarAsignacion editar = new EditarAsignacion();
            editar.Show();
            this.Hide();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ModoBusqueda modoBusqueda = new ModoBusqueda();
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
                    Convert.ToInt32(fila.Cells["AsignacionID"].Value),
                    fila.Cells["AsignacionTitulo"].Value.ToString(),
                    fila.Cells["AsignacionDescripcion"].Value.ToString(),
                    Convert.ToDateTime(fila.Cells["AsignacionFechaLimite"].Value),
                    Convert.ToInt32(fila.Cells["ClaseID"].Value),
                    Convert.ToInt32(fila.Cells["PlataformaID"].Value)
                );
            }
        }
    }
}
