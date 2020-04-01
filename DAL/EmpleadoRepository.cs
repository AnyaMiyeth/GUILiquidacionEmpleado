using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpleadoRepository
    {
        private List<Empleado> Empleados;

        public EmpleadoRepository()
        {
            Empleados = new List<Empleado>(); 
        }

        public void Guardar(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public void Eliminar(Empleado empleado)
        {
            Empleados.Remove(empleado);
        }

        public List<Empleado> Consultar()
        {
            return Empleados;
        }


        public List<Empleado> ConsultarTipo(string tipo)
        {
            List<Empleado> EmpleadosTipo = new List<Empleado>();
            foreach (var item in Empleados)
            {
                if (EsEncontrado(item.Tipo, tipo))
                {
                    EmpleadosTipo.Add(item);
                }
            }
            return EmpleadosTipo;
        }

        private bool EsEncontrado(string item, string tipo)
        {
            return item == tipo;

        }




        public Empleado Buscar(Empleado empleado)
        {
            foreach (var item in Empleados)
            {
                if (EsEncontrado(item, empleado))
                {
                    return item;
                }
            }
            return null;
        }

        private bool EsEncontrado(Empleado item, Empleado empleado)
        {
            return item.Identificacion == empleado.Identificacion;
               
        }

        
    }
}
