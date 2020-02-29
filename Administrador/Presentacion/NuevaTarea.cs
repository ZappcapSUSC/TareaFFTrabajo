using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class NuevaTarea : Form
    {
        Controladores.ControlNuevaTarea oCNuevaTarea = new Controladores.ControlNuevaTarea();
        int idTarea;
        string descripcionTarea;
        public NuevaTarea(int tarea = -1, string descripcion = null)
        {
            this.idTarea = tarea;
            this.descripcionTarea = descripcion;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text.Trim();
            if(!String.IsNullOrEmpty(descripcion))
            {
                if(this.idTarea == -1)
                {
                    oCNuevaTarea.AgregarTarea(descripcion);
                }
                else
                {
                    oCNuevaTarea.ModificarTarea(descripcion, this.idTarea);
                }
            }
            else
            {
                MessageBox.Show("No puede haber campos vacios", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void NuevaTarea_Load(object sender, EventArgs e)
        {
            if(this.idTarea != -1)
            {
                txtTareaID.Text = this.idTarea.ToString();
                txtDescripcion.Text = this.descripcionTarea;
            }
        }
    }
}
