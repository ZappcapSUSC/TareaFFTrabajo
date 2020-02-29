using System;
using System.Linq;
using Modelos;

namespace Controladores
{
    public class ControlNuevoEmpleado
    {
        public bool AgregarEmpleado(string nombre, string apellido)
        {
            using (dbEntities db = new dbEntities())
            {
                try
                {
                    Empleados empleado = new Empleados()
                    {
                        Nombre = nombre,
                        Apellido = apellido
                    };

                    db.Empleados.Add(empleado);
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ModificarEmpleado(string nombre, string apellido, int empleadoID)
        {
            using (dbEntities db = new dbEntities())
            {
                try
                {
                    var oEmpleado = db.Empleados.FirstOrDefault(empleado => empleado.ID == empleadoID);
                    if(oEmpleado != null)
                    {
                        oEmpleado.Nombre = nombre;
                        oEmpleado.Apellido = apellido;
                        db.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
