using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public virtual decimal Salario { get; set; }
        public virtual string Tipo { get; set; }
        public string NombreCompleto {
            get {
                return Nombre + " " + Apellido;
            }
        }

        public Empleado()
        {

        }

        public Empleado(string identificacion, string nombre, string apellido)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            
        }

    }
}
