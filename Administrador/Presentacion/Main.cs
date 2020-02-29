using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Main : Form
    {
        Controladores.ControlMain oCMain = new Controladores.ControlMain();
        private int idTareaSeleccionada = -1;
        private string descripcionTareaSeleccionada = "";

        private int idEmpleadoSeleccionado = -1;
        private string nombreEmpleadoSeleccionado = "";
        private string apellidoEmpleadoSeleccionado = "";

        public Main()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTareas.DataSource = oCMain.GetTareas();
            dgvEmpleadosCompletos.DataSource = oCMain.GetEmpleados();

            if (dgvTareas.Rows.Count > 0)
            {
                dgvTareas.Rows[0].Selected = true;
            }

            dgvEmpleadosAsignados.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
            dgvEmpleadosLibres.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
            dgvTareas.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
            dgvEmpleadosCompletos.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            dgvTareas.DataSource = oCMain.GetTareas();
            dgvEmpleadosCompletos.DataSource = oCMain.GetEmpleados();

            if (dgvTareas.Rows.Count > 0)
            {
                dgvTareas.Rows[0].Selected = true;
            }
            else
            {
                this.idTareaSeleccionada = -1;
                dgvEmpleadosAsignados.Rows.Clear();
                dgvEmpleadosLibres.Rows.Clear();
            }

            if (dgvEmpleadosCompletos.Rows.Count == 0)
            {
                this.idEmpleadoSeleccionado = -1;
            }

            if (dgvEmpleadosAsignados.Rows.Count > 0)
            {
                dgvEmpleadosAsignados.Rows[0].Selected = true;
            }

        }


        #region "Controles para tareas"

        private void dgvTareas_SelectionChanged(object sender, EventArgs e)
        {
            this.idTareaSeleccionada = (int)dgvTareas[0, (int)dgvTareas.CurrentRow.Index].Value;
            this.descripcionTareaSeleccionada = dgvTareas[1, (int)dgvTareas.CurrentRow.Index].Value.ToString();

            ActualizarDgvEmpleados();

            txtTareaIDSeleccionada.Text = idTareaSeleccionada.ToString();

        }

        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareas.Rows.Count > 0 || this.idTareaSeleccionada == -1)
            {
                NuevaTarea form = new NuevaTarea(this.idTareaSeleccionada, this.descripcionTareaSeleccionada);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen tareas para modificar");
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (this.idTareaSeleccionada > -1)
            {
                int idTareaAuxiliar = this.idTareaSeleccionada;
                DialogResult confirmacion = MessageBox.Show("¿Esta seguro de eliminar la tarea con ID " + this.idTareaSeleccionada + "?", "Eliminar tarea", MessageBoxButtons.YesNoCancel);

                if (confirmacion == DialogResult.Yes)
                {
                    if (oCMain.EliminarTarea(idTareaAuxiliar))
                    {
                        MessageBox.Show("Operación exitosa.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la operación.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe ninguna tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTareas.Rows.Count > 0)
            {
                NuevaTarea form = new NuevaTarea(this.idTareaSeleccionada, this.descripcionTareaSeleccionada);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen tareas para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            NuevaTarea form = new NuevaTarea();
            form.ShowDialog();
        }

        #endregion



        #region "Controles para empleados"
        private void ActualizarDgvEmpleados()
        {
            dgvEmpleadosAsignados.DataSource = oCMain.GetEmpleadosAsignados(idTareaSeleccionada);
            dgvEmpleadosLibres.DataSource = oCMain.GetEmpleadosNoAsignados(idTareaSeleccionada);
        }
        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosAsignados.Rows.Count > 0 || dgvTareas.Rows.Count > 0)
            {
                NuevoEmpleado form = new NuevoEmpleado(this.idEmpleadoSeleccionado, this.nombreEmpleadoSeleccionado, this.apellidoEmpleadoSeleccionado);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen usuarios que modificar");
            }
        }

        private void dgvEmpleadosCompletos_SelectionChanged(object sender, EventArgs e)
        {
            this.idEmpleadoSeleccionado = (int)dgvEmpleadosCompletos[0, (int)dgvEmpleadosCompletos.CurrentRow.Index].Value;
            this.nombreEmpleadoSeleccionado = dgvEmpleadosCompletos[1, (int)dgvEmpleadosCompletos.CurrentRow.Index].Value.ToString();
            this.apellidoEmpleadoSeleccionado = dgvEmpleadosCompletos[2, (int)dgvEmpleadosCompletos.CurrentRow.Index].Value.ToString();

            ActualizarDgvEmpleados();

            txtEmpleadoIDSeleccionado.Text = this.idEmpleadoSeleccionado.ToString();
        }
      
        private void dgvEmpleadosCompletos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleadosAsignados.Rows.Count > 0 || dgvTareas.Rows.Count > 0)
            {
                NuevoEmpleado form = new NuevoEmpleado(this.idEmpleadoSeleccionado, this.nombreEmpleadoSeleccionado, this.apellidoEmpleadoSeleccionado);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen usuarios que modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvEmpleadosAsignados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleadosAsignados.Rows.Count > 0)
            {
                oCMain.RetirarEmpleadoDeTarea((int)dgvTareas[0, (int)dgvTareas.CurrentRow.Index].Value, (int)dgvEmpleadosAsignados[0, (int)dgvEmpleadosAsignados.CurrentRow.Index].Value);
                ActualizarDgvEmpleados();
            }
        }

        private void dgvEmpleadosLibres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleadosLibres.Rows.Count > 0)
            {
                oCMain.AsignarEmpleadoATarea((int)dgvTareas[0, (int)dgvTareas.CurrentRow.Index].Value, (int)dgvEmpleadosLibres[0, (int)dgvEmpleadosLibres.CurrentRow.Index].Value);
                ActualizarDgvEmpleados();
            }
        }

        private void btnAsignarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosLibres.Rows.Count > 0)
            {
                oCMain.AsignarEmpleadoATarea((int)dgvTareas[0, (int)dgvTareas.CurrentRow.Index].Value, (int)dgvEmpleadosLibres[0, (int)dgvEmpleadosLibres.CurrentRow.Index].Value);
                ActualizarDgvEmpleados();
            }
        }

        private void btnDesasignarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosAsignados.Rows.Count > 0)
            {
                oCMain.RetirarEmpleadoDeTarea((int)dgvTareas[0, (int)dgvTareas.CurrentRow.Index].Value, (int)dgvEmpleadosAsignados[0, (int)dgvEmpleadosAsignados.CurrentRow.Index].Value);
                ActualizarDgvEmpleados();
            }
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            NuevoEmpleado form = new NuevoEmpleado();
            form.ShowDialog();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (this.idEmpleadoSeleccionado > -1)
            {
                int idEmpleadoAuxiliar = this.idEmpleadoSeleccionado;
                DialogResult confirmacion = MessageBox.Show("¿Esta seguro de eliminar la tarea con la tarea: " + this.idEmpleadoSeleccionado + "?", "Eliminar tarea", MessageBoxButtons.YesNoCancel);

                if (confirmacion == DialogResult.Yes)
                {
                    if (oCMain.EliminarEmpleado(idEmpleadoAuxiliar))
                    {
                        MessageBox.Show("Operación exitosa.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la operación.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe ningun empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
