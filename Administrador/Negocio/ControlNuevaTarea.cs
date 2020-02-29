using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class ControlNuevaTarea
    {
        public bool AgregarTarea(string descripcion)
        {
            using (dbEntities db = new dbEntities())
            {
                try
                {
                    Tareas tarea = new Tareas()
                    {
                        Descripcion = descripcion,
                        Fecha = DateTime.Today
                    };

                    db.Tareas.Add(tarea);
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ModificarTarea(string descripcion, int tareaID)
        {
            using (dbEntities db = new dbEntities())
            {
                try
                {
                    var oTarea = db.Tareas.FirstOrDefault(tarea => tarea.ID == tareaID);
                    if(oTarea != null)
                    {
                        oTarea.Descripcion = descripcion;
                        db.SaveChanges();
                    }
                    return true;
                } catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
