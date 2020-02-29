using System;
using System.Collections.Generic;
using System.Linq;
using Modelos;

namespace Controladores
{
    public class ControlMain
    {


        #region "Metodos relacionados a las tareas"
        public IEnumerable<ModeloTarea> GetTareas()
        {
            //Obtiene la lista de tareas completa

            using (dbEntities db = new dbEntities())
            {
                IEnumerable<ModeloTarea> lista = (from d in db.Tareas
                                                  select new ModeloTarea
                                                  {
                                                      Id = d.ID,
                                                      Descripcion = d.Descripcion
                                                  }).ToList();
                return lista;
            }
        }
        private List<int> GetIndicesEmpleadosTarea(int tareaID)
        {
            using (Modelos.dbEntities db = new Modelos.dbEntities())
            {
                //Lista de objetos de relacion empleado/tarea segun ID de tarea
                IEnumerable<Modelos.ModeloRelacion> lRelacionSoloTareaId = (from relacion in db.RelacionTareaEmpleado
                                                                            select new Modelos.ModeloRelacion
                                                                            {
                                                                                Id_Empleado = relacion.FK_Empleado,
                                                                                Id_Tarea = relacion.FK_Tarea
                                                                            }).Where(relacion => relacion.Id_Tarea == tareaID).ToList();

                //Lista solo de enteros para filtrar empleados
                List<int> lIdEmpleadosSoloTareaId = new List<int>();

                foreach (Modelos.ModeloRelacion item in lRelacionSoloTareaId)
                {
                    lIdEmpleadosSoloTareaId.Add(item.Id_Empleado);
                }

                return lIdEmpleadosSoloTareaId;
            }

        }
        public bool EliminarTarea(int tareaID)
        {
            //Metodo que elimina tarea en base a una ID a si mismo eliminando fisicamente sus relaciones

            //Obtiene la tarea descrita por su ID y sus relaciones y las elimina a trabes de Entity framework

            try
            {
                using (dbEntities db = new dbEntities())
                {
                    Tareas tarea = (from tar in db.Tareas
                                    select tar).FirstOrDefault(tar => tar.ID == tareaID);

                    IEnumerable<RelacionTareaEmpleado> relaciones = (from rel in db.RelacionTareaEmpleado
                                                                     select rel).Where(rel => rel.FK_Tarea == tareaID);

                    db.Tareas.Remove(tarea);
                    db.RelacionTareaEmpleado.RemoveRange(relaciones);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        #endregion

        #region "Metodos relacionados a los empleados"
        public IEnumerable<ModeloEmpleado> GetEmpleados()
        {
            //Metodo que obtiene lista completa de empleados

            using (dbEntities db = new dbEntities())
            {
                IEnumerable<ModeloEmpleado> lista = (from d in db.Empleados
                                                     select new ModeloEmpleado
                                                     {
                                                         Id = d.ID,
                                                         Nombre = d.Nombre,
                                                         Apellido = d.Apellido
                                                     }).ToList();
                return lista;
            }
        }

        public List<ModeloEmpleado> GetEmpleadosAsignados(int tareaID)
        {
            //Obtiene la lista de empleados de la tarea seleccionada según su ID

            using (Modelos.dbEntities db = new Modelos.dbEntities())
            {
                List<int> lIdEmpleadosAsignados = GetIndicesEmpleadosTarea(tareaID);

                //Filtrado de empleados
                List<Modelos.ModeloEmpleado> lEmpleadosSoloTareaId = (from empleado in db.Empleados
                                                                      select new Modelos.ModeloEmpleado
                                                                      {
                                                                          Id = empleado.ID,
                                                                          Nombre = empleado.Nombre,
                                                                          Apellido = empleado.Apellido
                                                                      }).Where(n => lIdEmpleadosAsignados.Contains(n.Id)).ToList();

                return lEmpleadosSoloTareaId;
            }
        }

        public List<ModeloEmpleado> GetEmpleadosNoAsignados(int tareaID)
        {
            //Obtiene la lista de empleados no asignados a la tarea especificada como tareaID

            using (Modelos.dbEntities db = new Modelos.dbEntities())
            {

                List<int> lIdEmpleadosAsignados = GetIndicesEmpleadosTarea(tareaID);

                //Filtrado de empleados
                List<Modelos.ModeloEmpleado> lEmpleadosLibresTareaId = (from empleado in db.Empleados
                                                                        select new Modelos.ModeloEmpleado
                                                                        {
                                                                            Id = empleado.ID,
                                                                            Nombre = empleado.Nombre,
                                                                            Apellido = empleado.Apellido
                                                                        }).Where(n => !lIdEmpleadosAsignados.Contains(n.Id)).ToList();

                return lEmpleadosLibresTareaId;
            }
        }

        public void AsignarEmpleadoATarea(int tareaID, int empleadoID)
        {
            //Asigna empleado el empleado a la tarea según sus ID insertando una relación en la tabla RelacionTareaEmpleado

            using (dbEntities db = new dbEntities())
            {
                RelacionTareaEmpleado relacion = new RelacionTareaEmpleado()
                {
                    FK_Empleado = empleadoID,
                    FK_Tarea = tareaID
                };


                db.RelacionTareaEmpleado.Add(relacion);
                db.SaveChanges();
            }
        }

        public void RetirarEmpleadoDeTarea(int tareaID, int empleadoID)
        {
            //Retira el empleado de la tarea seleccionada borrando fisicamente su relación de la tabla RelacionTareaempleado

            using (dbEntities db = new dbEntities())
            {
                RelacionTareaEmpleado relacion = (from rel in db.RelacionTareaEmpleado
                                                  select rel).FirstOrDefault(rel => rel.FK_Empleado == empleadoID && rel.FK_Tarea == tareaID);

                db.RelacionTareaEmpleado.Remove(relacion);
                db.SaveChanges();
            }
        }

        public bool EliminarEmpleado(int empleadoID)
        {
            //Metodo que elimina físicamente el empleado y todas sus relaciones con tareas.

            try
            {
                using (dbEntities db = new dbEntities())
                {
                    Empleados empleado = (from emp in db.Empleados
                                          select emp).FirstOrDefault(emp => emp.ID == empleadoID);

                    IEnumerable<RelacionTareaEmpleado> relaciones = (from rel in db.RelacionTareaEmpleado
                                                                     select rel).Where(rel => rel.FK_Empleado == empleadoID);

                    db.Empleados.Remove(empleado);
                    db.RelacionTareaEmpleado.RemoveRange(relaciones);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion








    }
}
