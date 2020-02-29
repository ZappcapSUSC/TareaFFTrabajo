using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class NuevoEmpleado : Form
    {
        Controladores.ControlNuevoEmpleado oCNuevoEmpleado = new Controladores.ControlNuevoEmpleado();
        int idEmpleado;
        
        public NuevoEmpleado(int empleado = -1, string nombre = "", string apellido = "")
        {
            InitializeComponent();
            this.idEmpleado = empleado;
            txtEmpleadoID.Text = empleado.ToString();
            txtNombreEmpleado.Text = nombre;
            txtApellidoEmpleado.Text = apellido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = txtNombreEmpleado.Text.Trim();
            string apellidoEmpleado = txtApellidoEmpleado.Text.Trim();

            if(!String.IsNullOrEmpty(nombreEmpleado) && !String.IsNullOrEmpty(apellidoEmpleado))
            {
                if (this.idEmpleado > -1)
                {
                    oCNuevoEmpleado.ModificarEmpleado(nombreEmpleado, apellidoEmpleado, this.idEmpleado);
                }
                else
                {
                    oCNuevoEmpleado.AgregarEmpleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text);
                }
            }
            else
            {
                MessageBox.Show("No puede haber campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
