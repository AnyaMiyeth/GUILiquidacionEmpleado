using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmpleadoService
    {


        public List<Empleado> Consultar() {
            return Datos.Empleado.Consultar();
        }

        public List<Empleado> Consultar(string tipo)
        {
            return Datos.Empleado.ConsultarTipo(tipo);
        }


        public string Guardar(Empleado trabajador)
        {

            if (Datos.Empleado.Buscar(trabajador) == null)
            {
                Datos.Empleado.Guardar(trabajador);
                return "Se registró al empleado " + trabajador.NombreCompleto;
            }
            else
            {
                return $"El empleado {trabajador.NombreCompleto} ya fue registrada!!!";
            }
        }


        public string Eliminar(Empleado empleado) {

            if (Datos.Empleado.Buscar(empleado) != null)
            {
                Datos.Empleado.Eliminar(empleado);
                return "Se eliminó al empleado " + empleado.NombreCompleto;
            }
            else
            {
                return "El empleado con esa identificación no existe";
            }

        }


        public Empleado Consultar(Empleado empleado)
        {

           return Datos.Empleado.Buscar(empleado);

        }
    }

    
}
